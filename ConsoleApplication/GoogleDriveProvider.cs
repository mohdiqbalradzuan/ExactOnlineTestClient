using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class GoogleDriveProvider : CloudStorageProvider
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
        private static string[] _scopes = { DriveService.Scope.DriveReadonly };
        private static string _applicationName = "Drive API .NET Quickstart";
        private static DriveService _service;
        private static int _sleepTimer = 10000;
        private static string _savedStartPageToken;

        public GoogleDriveProvider() : base("Google Drive")
        {
            Authenticate();
            RetrieveStartPageToken();
        }

        private void RetrieveStartPageToken()
        {
            var response = _service.Changes.GetStartPageToken().Execute();
            string startPageToken = response.StartPageTokenValue;
            Debug.WriteLine(String.Format("Start token at {0}: {1}",
            DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss"), startPageToken));

            // Pause execution here and upload new files on the drive at this point
            Thread.Sleep(_sleepTimer);
        }

        public override MemoryStream RetrieveFileStream(string fileId)
        {
            var request = _service.Files.Get(fileId);
            request.Fields = "id, name, description, trashed";
            var file = request.Execute();
            var stream = new System.IO.MemoryStream();

            if (file.Trashed.HasValue && !file.Trashed.Value)
            {
                // Add a handler which will be notified on progress changes.
                // It will notify on each chunk download and when the
                // download is completed or failed.
                request.MediaDownloader.ProgressChanged +=
                    (IDownloadProgress progress) =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };
                request.Download(stream);
            }

            return stream;
        }

        public override FileInfo RetrieveFileInfo(string fileId)
        {
            var request = _service.Files.Get(fileId);
            request.Fields = "id, name, description, trashed";
            var file = request.Execute();
            FileInfo fileInfo = new FileInfo(file.Name, file.Id);

            return fileInfo;
        }

        public override List<string> RetrieveListOfChange()
        {
            Console.WriteLine("What is your previous start page token");
            _savedStartPageToken = Console.ReadLine();

            List<string> changesFileIdList = new List<string>();

            // Begin with our last saved start token for this user or the
            // current token from GetStartPageToken()
            string pageToken = _savedStartPageToken;
            while (pageToken != null)
            {
                var request = _service.Changes.List(pageToken);
                request.Spaces = "drive";
                request.IncludeRemoved = true;
                var changes = request.Execute();
                foreach (var change in changes.Changes)
                {
                    // Process change
                    Debug.WriteLine("Change found for file: " + change.FileId);
                    Debug.WriteLine("Change type for this file: " + change.Type);
                    changesFileIdList.Add(change.FileId);
                }
                if (changes.NewStartPageToken != null)
                {
                    // Last page, save this token for the next polling interval
                    _savedStartPageToken = changes.NewStartPageToken;
                }
                pageToken = changes.NextPageToken;
            }

            return changesFileIdList;
        }

        public override void Authenticate()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    _scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Debug.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            _service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = _applicationName,
            });
        }
    }
}

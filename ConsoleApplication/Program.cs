using ExactOnline.Client.Models.CRM;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Helpers;
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
using System.Threading;
using Documents = ExactOnline.Client.Models.Documents;

namespace ConsoleApplication
{
    class Program
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
        static string[] Scopes = { DriveService.Scope.DriveReadonly };
        static string ApplicationName = "Drive API .NET Quickstart";
        static int SleepTimer = 10000;

        [STAThread]
        static void Main(string[] args)
        {
            DriveService service = new DriveService();
            ExactOnlineClient client = null;
            string startPageToken = String.Empty;

            AuthenticateGoogle(ref service);
            AuthenticateExactOnline(ref client);

            RetrieveStartPageToken(service, ref startPageToken);

            // Key in the previous start page token
            Console.WriteLine("What is your previous start page token");
            startPageToken = Console.ReadLine();
            List<string> changesFileIdList = new List<string>();
            Account account = new Account();
            
            RetrieveGoogleDriveChangeList(service, ref startPageToken, ref changesFileIdList);
            //RetrieveExactOnlineAccount(client, ref account);
            CopyGoogleDriveDocsToExactOnline(service, client, changesFileIdList);
        }

        private static void CopyGoogleDriveDocsToExactOnline(DriveService service, 
            ExactOnlineClient client,  
            List<string> changesFileIdList)
        {
            var documentCategoryFields = new[] { "ID" };
            var documentCategory = client.For<Documents.DocumentCategory>().Select(documentCategoryFields).Get().FirstOrDefault();

            foreach (var fileId in changesFileIdList)
            {
                var request = service.Files.Get(fileId);
                request.Fields = "id, name, description, trashed";
                var file = request.Execute();

                if (file.Trashed.HasValue && !file.Trashed.Value)
                {
                    var stream = new System.IO.MemoryStream();

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

                    // Create a doc for the selected account
                    Documents.Document document = new Documents.Document
                    {
                        Subject = file.Name,
                        Body = file.Id,
                        Category = documentCategory.ID,
                        Type = 55, //Miscellaneous
                        DocumentDate = DateTime.Now.Date,
                    };

                    var createDoc = client.For<Documents.Document>().Insert(ref document);
                    Debug.WriteLine(String.Format("Document created : {0}", createDoc));
                    Debug.WriteLine(String.Format("Document {0} - {1} - {2}", document.ID, document.Created.ToString(), document.Subject));

                    Documents.DocumentAttachment attachment = new Documents.DocumentAttachment
                    {
                        Attachment = stream.ToArray(),
                        Document = document.ID,
                        FileName = file.Name,
                        FileSize = stream.ToArray().Length,
                        Url = file.WebViewLink,
                    };

                    var createAttachment = client.For<Documents.DocumentAttachment>().Insert(ref attachment);
                    Debug.WriteLine(String.Format("Document attachment created : {0}", createAttachment));
                    Debug.WriteLine(String.Format("Document attachment {0}", attachment.ID));
                }
            }
        }
        
        private static void AuthenticateExactOnline(ref ExactOnlineClient client)
        {
            // To make this work set the authorisation properties of your test app in the testapp.config.
            var testApp = new TestApp();

            var connector = new Connector(testApp.ClientId.ToString(), testApp.ClientSecret, testApp.CallbackUrl);
            client = new ExactOnlineClient(connector.EndPoint, connector.GetAccessToken);
        }

        private static void RetrieveGoogleDriveChangeList(DriveService service,
            ref string startPageToken,
            ref List<string> changesFileIdList)
        {
            // Begin with our last saved start token for this user or the
            // current token from GetStartPageToken()
            string pageToken = startPageToken;
            while (pageToken != null)
            {
                var request = service.Changes.List(pageToken);
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
                    startPageToken = changes.NewStartPageToken;
                }
                pageToken = changes.NextPageToken;
            }
        }

        private static void RetrieveStartPageToken(DriveService service, ref string startPageToken)
        {
            var response = service.Changes.GetStartPageToken().Execute();
            startPageToken = response.StartPageTokenValue;
            Debug.WriteLine(String.Format("Start token at {0}: {1}", 
                DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss"), startPageToken));

            // Pause execution here and upload new files on the drive at this point
            Thread.Sleep(SleepTimer);
        }

        private static void AuthenticateGoogle(ref DriveService service)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Debug.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }
    }
}

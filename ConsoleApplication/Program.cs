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
        [STAThread]
        static void Main(string[] args)
        {
            ExactOnlineClient client = null;
            AuthenticateExactOnline(ref client);

            CloudStorageProvider provider = new GoogleDriveProvider();

            List<string> changeFileIdList = provider.RetrieveListOfChange();

            foreach(string fileId in changeFileIdList)
            {
                MemoryStream ms = provider.RetrieveFileStream(fileId);
                FileInfo fileInfo = provider.RetrieveFileInfo(fileId);

                var documentCategoryFields = new[] { "ID" };
                var documentCategory = client.For<Documents.DocumentCategory>()
                    .Select(documentCategoryFields).Get().FirstOrDefault();

                // Create a doc for the selected account
                Documents.Document document = new Documents.Document
                {
                    Subject = fileInfo.FileName,
                    Body = fileInfo.FileId,
                    Category = documentCategory.ID,
                    Type = 55, //Miscellaneous
                    DocumentDate = DateTime.Now.Date
                };

                var createDoc = client.For<Documents.Document>().Insert(ref document);
                Debug.WriteLine(String.Format("Document created : {0}", createDoc));
                Debug.WriteLine(String.Format("Document {0} - {1} - {2}", document.ID, document.Created.ToString(), document.Subject));

                Documents.DocumentAttachment attachment = new Documents.DocumentAttachment
                {
                    Attachment = ms.ToArray(),
                    Document = document.ID,
                    FileName = fileInfo.FileName,
                    FileSize = ms.ToArray().Length
                };

                var createAttachment = client.For<Documents.DocumentAttachment>().Insert(ref attachment);
                Debug.WriteLine(String.Format("Document attachment created : {0}", createAttachment));
                Debug.WriteLine(String.Format("Document attachment {0}", attachment.ID));
            }
        }
        
        private static void AuthenticateExactOnline(ref ExactOnlineClient client)
        {
            // To make this work set the authorisation properties of your test app in the testapp.config.
            var testApp = new TestApp();

            var connector = new Connector(testApp.ClientId.ToString(), testApp.ClientSecret, testApp.CallbackUrl);
            client = new ExactOnlineClient(connector.EndPoint, connector.GetAccessToken);
        }
    }
}

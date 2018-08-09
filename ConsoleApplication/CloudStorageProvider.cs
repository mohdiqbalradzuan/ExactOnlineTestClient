using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    abstract class CloudStorageProvider
    {
        public CloudStorageProvider(string name)
        {
            Debug.WriteLine("Using " + name);
        }

        public abstract FileInfo RetrieveFileInfo(string fileId);
        public abstract MemoryStream RetrieveFileStream(string fileId);
        public abstract List<string> RetrieveListOfChange();
        public abstract void Authenticate();
    }
}

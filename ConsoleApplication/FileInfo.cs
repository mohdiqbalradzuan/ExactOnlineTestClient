using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class FileInfo
    {
        private string _fileName;
        private string _fileId;

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        public string FileId
        {
            get { return _fileId; }
            set { _fileId = value; }
        }

        public FileInfo(string name, string id)
        {
            _fileName = name;
            _fileId = id;
        }
    }
}

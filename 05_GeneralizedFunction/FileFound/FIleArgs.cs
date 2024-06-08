using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GeneralizedFunction.FileFound
{
    public class FileArgs : EventArgs
    {
        public string FileName { get; set; }
        public FileArgs(FileInfo fileInfo) : base() 
        {
            FileName = fileInfo.FullName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _05_GeneralizedFunction.Extentions;

namespace _05_GeneralizedFunction.FileFound
{
    public class FileFoundler(string PathFile)
    {
        public event EventHandler? FileFound;
        public bool Continuation { get; set; }
        public string? MaxPathString { get; set; }
        public void StartFound() 
        {
            Continuation = true;
            string[] filesPath = Directory.GetFiles(PathFile);
            MaxPathString = filesPath.GetMax(GetWeightString);

            foreach (var item in filesPath)
            {
                if (Continuation)
                {
                    FileFound?.Invoke(this, new FileArgs(new FileInfo(item)));
                }                
            }
        }
        //Функция возврата веса файлв в байтах.
        float GetWeightString(string value) 
        {            
            return new FileInfo(value).Length;
        }
    }
}

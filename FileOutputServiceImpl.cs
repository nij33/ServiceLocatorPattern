using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    public class FileOutputServiceImpl : IFileOutputService
    {
        public void OutputToFile(string fileName, string content)
        {
            File.WriteAllText(fileName, content);
        }
    }
}

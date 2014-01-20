using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    public interface IFileOutputService
    {
        void OutputToFile(string fileName, string content);
    }
}

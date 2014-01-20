using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    public interface IConsoleOutputService
    {
        void OutputToConsole(string content);
    }
}

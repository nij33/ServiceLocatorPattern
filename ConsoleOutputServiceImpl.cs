using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    public class ConsoleOutputServiceImpl : IConsoleOutputService
    {
        public void OutputToConsole(string content)
        {
            Console.WriteLine(content);
        }
    }
}

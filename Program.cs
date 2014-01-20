using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    class Program
    {
    
        static void Main(string[] args)
        {
            var fileName = @"c:\test.txt";
            var content = @"Hello World!";

            var fileService = (IFileOutputService)ServiceLocator.Instance.GetService(typeof(IFileOutputService));
            fileService.OutputToFile(fileName, content);

            //var consoleService = (IConsoleOutputService)ServiceLocator.Instance.GetService(typeof(IConsoleOutputService));
            //consoleService.OutputToConsole(content);
            //Console.ReadKey();
        }
    }
}

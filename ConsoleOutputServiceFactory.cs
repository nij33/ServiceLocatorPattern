using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    public class ConsoleOutputServiceFactory : ServiceFactory
    {
        protected override object DoGetService()
        {
            return new ConsoleOutputServiceImpl();
        }

        public override Type ServiceContractType
        {
            get { return typeof(IConsoleOutputService); }
        }
    }
}

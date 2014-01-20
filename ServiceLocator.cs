using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    public sealed class ServiceLocator
    {
        private static readonly ServiceLocator instance = new ServiceLocator();
        private static readonly InitialContext initialContext = new InitialContext();

        private ServiceLocator() { }

        public static ServiceLocator Instance
        {
            get { return instance; }
        }

        public object GetService(Type contractType)
        {
            return initialContext.GetServiceByType(contractType);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    public class InitialContext
    {
        private readonly Dictionary<Type, ServiceFactory> serviceFactories = new Dictionary<Type, ServiceFactory>();

        public InitialContext()
        {
            foreach(var type in this.GetType().Assembly.GetExportedTypes())
            {
                if (type.IsSubclassOf(typeof(ServiceFactory)))
                {
                    var factory = (ServiceFactory)Activator.CreateInstance(type);
                    serviceFactories.Add(factory.ServiceContractType, factory);
                }
            }
        }

        public object GetServiceByType(Type serviceContractType)
        {
            var factory = serviceFactories[serviceContractType];
            if (factory != null)
                return factory.GetService();
            throw new InvalidOperationException();
        }
    }
}

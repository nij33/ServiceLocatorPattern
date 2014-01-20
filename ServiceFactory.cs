using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    public abstract class ServiceFactory
    {
        private object serviceImpl = null;

        public object GetService()
        {
            if (serviceImpl == null)
                serviceImpl = this.DoGetService();
            return serviceImpl;
        }

        protected abstract object DoGetService();

        public abstract Type ServiceContractType { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    public class FileOutputServiceFactory : ServiceFactory
    {
        protected override object DoGetService()
        {
            return new FileOutputServiceImpl();
        }

        public override Type ServiceContractType
        {
            get { return typeof(IFileOutputService); }
        }
    }
}

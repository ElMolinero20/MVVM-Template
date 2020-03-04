using MVVM.Services.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Services
{
    public class ServiceLocator
    {
        /// <summary>
        /// Holds the reference to the cache
        /// </summary>
        public ServiceCache Cache { get; set; }

        /// <summary>
        /// Instantiates the cache
        /// </summary>
        public ServiceLocator()
        {
            Cache = new ServiceCache();
        }

        /// <summary>
        /// Tries to retrieve the service from cache otherwise instantiate it, register it and return it then
        /// </summary>
        /// <param name="serviceName"></param>
        /// <returns></returns>
        public IService GetService(string serviceName)
        {
            object service = Cache.GetService(serviceName);
            if (service != null && service is IService)
            {
                return service as IService;
            }
            else
            {
                service = Assembly.GetExecutingAssembly().CreateInstance(serviceName);
                if (service != null && service is IService)
                {
                    return service as IService;
                }
                else
                {
                    throw new Exception("Service not found"); 
                }
            }
        }
    }
}

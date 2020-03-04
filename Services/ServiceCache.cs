using MVVM.Services.Locator;
using System.Collections.Generic;

namespace MVVM.Services
{
    public class ServiceCache
    {
        /// <summary>
        /// Holds the services with its type as key and the service itself as value.
        /// </summary>
        public Dictionary<string, IService> Services { get; set; }

        /// <summary>
        /// Initialization of the dictionary.
        /// </summary>
        public ServiceCache()
        {
            Services = new Dictionary<string, IService>();
        }

        /// <summary>
        /// Registers the service in the cache so that it can be retrieved later.
        /// </summary>
        /// <param name="service">The service to be registered</param>
        public void Register(IService service)
        {
            Services.Add(service.Name, service);
        }

        /// <summary>
        /// Retrieves the demanded service from the cache.
        /// </summary>
        /// <param name="serviceName">The type of the service to identify the service</param>
        /// <returns>The service when it exists in the cache otherwise null</returns>
        public IService GetService(string serviceName)
        {
            if (Services.ContainsKey(serviceName))
            {
                return Services[serviceName];
            }
            return null;
        }
    }
}

using Microsoft.Extensions.Configuration;
using System;

namespace BlazorLazyLoadingApp.Client 
{
    public class LoadAssembliesService
    {
        IConfiguration Configuration;

        public LoadAssembliesService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IEnumerable<string> GetCounterAssemblies()
        {
            IConfigurationSection fileNamesSection = Configuration.GetSection("AssembliesCounter");
            IEnumerable<KeyValuePair<string, string>> fileNamesArray = fileNamesSection.AsEnumerable();

            IEnumerable<IConfigurationSection> fileNamesSection2 = Configuration.GetSection("AssembliesCounter").GetChildren();
            IEnumerable<string> retval = fileNamesSection2.ToArray().Select(c => c.Value).ToArray().AsEnumerable();
            return retval;
        }

        public IEnumerable<string> GetComponentRefAssemblies()
        {
            IConfigurationSection fileNamesSection = Configuration.GetSection("AssembliesComponentRef");
            IEnumerable<KeyValuePair<string, string>> fileNamesArray = fileNamesSection.AsEnumerable();
            return Configuration.GetSection("AssembliesComponentRef").GetChildren().ToArray().Select(c => c.Value).ToArray().AsEnumerable();
        }
         
        public IEnumerable<string> GetWeatherAssemblies()
        {
            IConfigurationSection fileNamesSection = Configuration.GetSection("AssembliesWeather");
            IEnumerable<KeyValuePair<string, string>> fileNamesArray = fileNamesSection.AsEnumerable();

            IEnumerable<IConfigurationSection> fileNamesSection2 = Configuration.GetSection("AssembliesWeather").GetChildren();
            IEnumerable<string> retval = fileNamesSection2.ToArray().Select(c => c.Value).ToArray().AsEnumerable();
            return retval;
        }
    }
}

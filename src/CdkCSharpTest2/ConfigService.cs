using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdkCSharpTest2
{
    public class ConfigService
    {
        public Config GetConfig(string fileName)
        {
            var runningDirectory = Directory.GetCurrentDirectory();
            var configLocation = Path.Combine(runningDirectory, fileName); 
            string fileContents = File.ReadAllText(configLocation);
            var config = JsonConvert.DeserializeObject<Config>(fileContents);
            return config;
        }   
    }
}

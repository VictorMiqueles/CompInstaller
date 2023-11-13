using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompInstaller
{
    public class ConfigReader
    {
        public ConfigReader()
        {
            
        }

        public dynamic ReadConfig(string fileName)
        {
            
            if (!File.Exists(fileName))
                throw new FileNotFoundException("Cannot find Json file");

            var fileContents = File.ReadAllText(fileName);

            dynamic jsonConfig = JsonConvert.DeserializeObject(fileContents);

            return jsonConfig;
        }


    }
}

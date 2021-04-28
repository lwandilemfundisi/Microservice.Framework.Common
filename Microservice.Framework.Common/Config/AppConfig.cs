using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public class AppConfig
    {
        public static IConfigurationRoot GetConfig(string configName)
        {
            return new ConfigurationBuilder().AddJsonFile(configName).Build();
        }
    }
}

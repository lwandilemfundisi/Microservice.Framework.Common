using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public class JsonOptions : IJsonOptions
    {
        public void Apply(JsonSerializerSettings settings)
        {
        }

        public static JsonOptions New => new JsonOptions();
    }
}

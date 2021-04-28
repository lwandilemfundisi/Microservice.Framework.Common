using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public interface IJsonOptions
    {
        void Apply(JsonSerializerSettings settings);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public interface IJsonSerializer
    {
        string Serialize(object obj, bool indented = false);
        object Deserialize(string json, Type type);
        T Deserialize<T>(string json);
    }
}

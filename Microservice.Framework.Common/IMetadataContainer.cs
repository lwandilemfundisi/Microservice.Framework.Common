using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public interface IMetadataContainer : IReadOnlyDictionary<string, string>
    {
        string GetMetadataValue(string key);

        T GetMetadataValue<T>(string key, Func<string, T> converter);
    }
}

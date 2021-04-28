using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public class MetadataParseException : Exception
    {
        public MetadataParseException(string key, string value, Exception innerException)
            : base($"Failed to parse metadata key '{key}' with value '{value}' due to '{innerException.Message}'", innerException)
        {
        }
    }
}

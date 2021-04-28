using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public static class SourceIdExtensions
    {
        public static bool IsNone(this ISourceId sourceId)
        {
            return string.IsNullOrEmpty(sourceId?.Value);
        }
    }
}

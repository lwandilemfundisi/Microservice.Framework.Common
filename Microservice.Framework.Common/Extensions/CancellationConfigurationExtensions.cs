using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Microservice.Framework.Common
{
    public static class CancellationConfigurationExtensions
    {
        public static CancellationToken Limit(this ICancellationConfiguration configuration, CancellationToken token, CancellationBoundary currentBoundary)
        {
            token.ThrowIfCancellationRequested();
            return currentBoundary < configuration.CancellationBoundary ? token : CancellationToken.None;
        }
    }
}

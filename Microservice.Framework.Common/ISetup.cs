using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public interface ISetup
    {
        int RetryCountOnOptimisticConcurrencyExceptions { get; }

        TimeSpan WaitThenTryAfterOnOptimisticConcurrencyExceptions { get; }

        bool ThrowSubscriberExceptions { get; }

        bool IsAsynchronousSubscribersEnabled { get; }

       CancellationBoundary CancellationBoundary { get; }
    }
}

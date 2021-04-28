using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public interface IResilientStrategy
    {
        Repeat CheckRetry(Exception exception, TimeSpan totalExecutionTime, int currentRetryCount);
    }
}

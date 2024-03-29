﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public class Setup : ISetup, ICancellationConfiguration
    {
        public int RetryCountOnOptimisticConcurrencyExceptions { get; set; }
        public TimeSpan WaitThenTryAfterOnOptimisticConcurrencyExceptions { get; set; }
        public bool ThrowSubscriberExceptions { get; set; }
        public bool IsAsynchronousSubscribersEnabled { get; set; }
        public CancellationBoundary CancellationBoundary { get; set; }

        public Setup()
        {
            RetryCountOnOptimisticConcurrencyExceptions = 4;
            WaitThenTryAfterOnOptimisticConcurrencyExceptions = TimeSpan.FromMilliseconds(1000);
            ThrowSubscriberExceptions = false;
            IsAsynchronousSubscribersEnabled = false;
            CancellationBoundary = CancellationBoundary.BeforeCommittingEvents;
        }
    }
}

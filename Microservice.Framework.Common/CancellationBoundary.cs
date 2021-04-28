using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public enum CancellationBoundary
    {
        BeforeUpdatingAggregate,
        BeforeCommittingEvents,
        BeforeNotifyingSubscribers,
        CancelAlways
    }
}

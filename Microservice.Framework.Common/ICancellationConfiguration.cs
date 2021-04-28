using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public interface ICancellationConfiguration
    {
        CancellationBoundary CancellationBoundary { get; }
    }
}

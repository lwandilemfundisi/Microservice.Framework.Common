using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public class OptimisticConcurrencyException : Exception
    {
        public OptimisticConcurrencyException(string message)
            : base(message)
        {
        }

        public OptimisticConcurrencyException(
            string message,
            Exception innerException)
            : base(message, innerException)
        {
        }
    }
}

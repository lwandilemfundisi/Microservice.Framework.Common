using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Microservice.Framework.Common
{
    [Serializable]
    public class XmlValueObjectException : Exception
    {
        #region Constructors
        public XmlValueObjectException() : base() { }

        public XmlValueObjectException(string message) : base(message) { }

        public XmlValueObjectException(string message, Exception innerExceptions) : base(message, innerExceptions) { }

        protected XmlValueObjectException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) { }

        #endregion
    }
}

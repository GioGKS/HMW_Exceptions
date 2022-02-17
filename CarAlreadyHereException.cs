using System;
using System.Runtime.Serialization;

namespace HMW_Exceptions
{
    [Serializable]
    internal class CarAlreadyHereException : Exception
    {
        public CarAlreadyHereException()
        {
        }

        public CarAlreadyHereException(string message) : base(message)
        {
        }

        public CarAlreadyHereException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarAlreadyHereException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
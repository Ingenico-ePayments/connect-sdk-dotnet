using System;
using System.Runtime.Serialization;

namespace Ingenico.Connect.Sdk
{
    [Serializable]
    internal class BodyHandlerException : Exception
    {
        public BodyHandlerException(string message) : base(message)
        {
        }

        public BodyHandlerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BodyHandlerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
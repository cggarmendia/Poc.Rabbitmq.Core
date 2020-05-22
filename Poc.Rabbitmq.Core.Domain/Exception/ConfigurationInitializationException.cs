using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception
{
    [Serializable]
    public class ConfigurationInitializationException : System.Exception
    {
        public ConfigurationInitializationException()
        {
        }

        public ConfigurationInitializationException(string message) : base(message)
        {
        }

        public ConfigurationInitializationException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected ConfigurationInitializationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
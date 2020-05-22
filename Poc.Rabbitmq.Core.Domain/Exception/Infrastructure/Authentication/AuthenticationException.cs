using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Authentication
{
    [Serializable]
    public class AuthenticationException : BaseException
    {
        public AuthenticationException()
        {
        }

        public AuthenticationException(string message) : base(message)
        {
        }

        public AuthenticationException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected AuthenticationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

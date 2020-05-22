using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Core
{
    [Serializable]
    public class AccountTransactionCodeException : BaseException
    {
        public AccountTransactionCodeException()
        {
        }

        public AccountTransactionCodeException(string message) : base(message)
        {
        }

        public AccountTransactionCodeException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected AccountTransactionCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

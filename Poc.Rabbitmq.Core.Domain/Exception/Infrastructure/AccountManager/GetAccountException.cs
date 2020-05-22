using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.AccountManager
{
    [Serializable]
    public class GetAccountException : BaseException
    {
        public GetAccountException()
        {
        }

        public GetAccountException(string message) : base(message)
        {
        }

        public GetAccountException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected GetAccountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.AccountManager
{
    [Serializable]
    public class GetAccountByReferenceException : BaseException
    {
        public GetAccountByReferenceException()
        {
        }

        public GetAccountByReferenceException(string message) : base(message)
        {
        }

        public GetAccountByReferenceException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected GetAccountByReferenceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

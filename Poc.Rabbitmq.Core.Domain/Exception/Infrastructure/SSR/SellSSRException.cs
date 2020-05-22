using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.SSR
{
    [Serializable]
    public class SellSSRException : BaseException
    {
        public SellSSRException()
        {
        }

        public SellSSRException(string message) : base(message)
        {
        }

        public SellSSRException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected SellSSRException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

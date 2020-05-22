using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Fee
{
    [Serializable]
    public class SellServiceFeeException : BaseException
    {
        public SellServiceFeeException()
        {
        }

        public SellServiceFeeException(string message) : base(message)
        {
        }

        public SellServiceFeeException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected SellServiceFeeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

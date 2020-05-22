using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Fee
{
    [Serializable]
    public class SellPenaltyFeeException : BaseException
    {
        public SellPenaltyFeeException()
        {
        }

        public SellPenaltyFeeException(string message) : base(message)
        {
        }

        public SellPenaltyFeeException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected SellPenaltyFeeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

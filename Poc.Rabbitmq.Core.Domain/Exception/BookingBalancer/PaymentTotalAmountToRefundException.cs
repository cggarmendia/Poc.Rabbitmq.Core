using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.BookingBalancer
{
    [Serializable]
    public class PaymentTotalAmountToRefundException : BaseException
    {
        public PaymentTotalAmountToRefundException()
        {
        }

        public PaymentTotalAmountToRefundException(string message) : base(message)
        {
        }

        public PaymentTotalAmountToRefundException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected PaymentTotalAmountToRefundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

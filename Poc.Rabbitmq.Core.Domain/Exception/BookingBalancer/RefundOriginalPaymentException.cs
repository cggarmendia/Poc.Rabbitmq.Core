using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.BookingBalancer
{
    [Serializable]
    public class RefundOriginalPaymentException : BaseException
    {
        public RefundOriginalPaymentException()
        {
        }

        public RefundOriginalPaymentException(string message) : base(message)
        {
        }

        public RefundOriginalPaymentException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected RefundOriginalPaymentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

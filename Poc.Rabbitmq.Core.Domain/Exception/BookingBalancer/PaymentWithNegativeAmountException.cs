using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.BookingBalancer
{
    [Serializable]
    public class PaymentWithNegativeAmountException : BaseException
    {
        public PaymentWithNegativeAmountException()
        {
        }

        public PaymentWithNegativeAmountException(string message) : base(message)
        {
        }

        public PaymentWithNegativeAmountException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected PaymentWithNegativeAmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

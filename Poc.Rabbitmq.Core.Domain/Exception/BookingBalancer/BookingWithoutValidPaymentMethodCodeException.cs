using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.BookingBalancer
{
    [Serializable]
    public class BookingWithoutValidPaymentMethodCodeException : BaseException
    {
        public BookingWithoutValidPaymentMethodCodeException()
        {
        }

        public BookingWithoutValidPaymentMethodCodeException(string message) : base(message)
        {
        }

        public BookingWithoutValidPaymentMethodCodeException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected BookingWithoutValidPaymentMethodCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

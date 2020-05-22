using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.BookingBalancer
{
    [Serializable]
    public class BookingBalanceDueException : BaseException
    {
        public BookingBalanceDueException()
        {
        }

        public BookingBalanceDueException(string message) : base(message)
        {
        }

        public BookingBalanceDueException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected BookingBalanceDueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Booking
{
    [Serializable]
    public class BookingCancelException : BaseException
    {
        public BookingCancelException()
        {
        }

        public BookingCancelException(string message) : base(message)
        {
        }

        public BookingCancelException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected BookingCancelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

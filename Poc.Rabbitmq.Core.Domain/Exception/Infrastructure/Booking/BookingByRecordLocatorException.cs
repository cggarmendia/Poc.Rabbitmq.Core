using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Booking
{
    [Serializable]
    public class BookingByRecordLocatorException : BaseException
    {
        public BookingByRecordLocatorException()
        {
        }

        public BookingByRecordLocatorException(string message) : base(message)
        {
        }

        public BookingByRecordLocatorException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected BookingByRecordLocatorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

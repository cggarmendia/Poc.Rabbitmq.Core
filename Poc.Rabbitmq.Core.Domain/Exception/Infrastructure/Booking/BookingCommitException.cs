using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Booking
{
    [Serializable]
    public class BookingCommitException : BaseException
    {
        public BookingCommitException()
        {
        }

        public BookingCommitException(string message) : base(message)
        {
        }

        public BookingCommitException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected BookingCommitException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

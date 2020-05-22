using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.BookingBalancer
{
    [Serializable]
    public class PendingTransferException : BaseException
    {
        public decimal AmountRefounded { get; set; }

        public PendingTransferException()
        {
        }

        public PendingTransferException(string message) : base(message)
        {
        }

        public PendingTransferException(string message, decimal amountRefounded) : base(message)
        {
            AmountRefounded = amountRefounded;
        }

        public PendingTransferException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected PendingTransferException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

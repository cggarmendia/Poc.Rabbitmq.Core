using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Payment
{
    [Serializable]
    public class AddPaymentException : BaseException
    {
        public AddPaymentException()
        {
        }

        public AddPaymentException(string message) : base(message)
        {
        }

        public AddPaymentException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected AddPaymentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

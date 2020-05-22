using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell
{
    [Serializable]
    public class RequestInvalidAmountException : BaseException
    {
        public RequestInvalidAmountException()
        {
        }

        public RequestInvalidAmountException(string message) : base(message)
        {
        }

        public RequestInvalidAmountException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected RequestInvalidAmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

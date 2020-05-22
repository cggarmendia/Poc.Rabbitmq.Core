using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell
{
    [Serializable]
    public class SoldOutCreditShellException : BaseException
    {
        public SoldOutCreditShellException()
        {
        }

        public SoldOutCreditShellException(string message) : base(message)
        {
        }

        public SoldOutCreditShellException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected SoldOutCreditShellException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

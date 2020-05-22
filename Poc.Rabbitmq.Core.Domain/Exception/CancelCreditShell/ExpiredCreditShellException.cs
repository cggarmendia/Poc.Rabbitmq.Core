using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell
{
    [Serializable]
    public class ExpiredCreditShellException : BaseException
    {
        public ExpiredCreditShellException()
        {
        }

        public ExpiredCreditShellException(string message) : base(message)
        {
        }

        public ExpiredCreditShellException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected ExpiredCreditShellException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

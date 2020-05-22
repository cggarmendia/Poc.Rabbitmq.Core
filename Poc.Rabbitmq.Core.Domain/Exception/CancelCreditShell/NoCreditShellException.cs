using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell
{
    [Serializable]
    public class NoCreditShellException : BaseException
    {
        public NoCreditShellException()
        {
        }

        public NoCreditShellException(string message) : base(message)
        {
        }

        public NoCreditShellException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected NoCreditShellException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

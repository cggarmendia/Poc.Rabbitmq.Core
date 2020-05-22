using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell
{
    [Serializable]
    public class UsedCreditShellException : BaseException
    {
        public UsedCreditShellException()
        {
        }

        public UsedCreditShellException(string message) : base(message)
        {
        }

        public UsedCreditShellException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected UsedCreditShellException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

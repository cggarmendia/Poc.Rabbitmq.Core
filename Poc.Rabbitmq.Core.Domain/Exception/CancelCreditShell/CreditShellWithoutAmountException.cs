using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell
{
    [Serializable]
    public class CreditShellWithoutAmountException : BaseException
    {
        public CreditShellWithoutAmountException()
        {
        }

        public CreditShellWithoutAmountException(string message) : base(message)
        {
        }

        public CreditShellWithoutAmountException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected CreditShellWithoutAmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

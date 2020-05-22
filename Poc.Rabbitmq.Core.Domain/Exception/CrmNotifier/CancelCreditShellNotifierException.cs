using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CrmNotifier
{
    [Serializable]
    public class CancelCreditShellNotifierException : BaseException
    {
        public CancelCreditShellNotifierException()
        {
        }

        public CancelCreditShellNotifierException(string message) : base(message)
        {
        }

        public CancelCreditShellNotifierException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected CancelCreditShellNotifierException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

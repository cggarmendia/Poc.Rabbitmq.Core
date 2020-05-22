using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell
{
    [Serializable]
    public class IncorrectCurrencyCodeException : BaseException
    {
        public IncorrectCurrencyCodeException()
        {
        }

        public IncorrectCurrencyCodeException(string message) : base(message)
        {
        }

        public IncorrectCurrencyCodeException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectCurrencyCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

}

using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell
{
    [Serializable]
    public class NoCreditShellWithoutJourneysException : BaseException
    {
        public NoCreditShellWithoutJourneysException()
        {
        }

        public NoCreditShellWithoutJourneysException(string message) : base(message)
        {
        }

        public NoCreditShellWithoutJourneysException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected NoCreditShellWithoutJourneysException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

}

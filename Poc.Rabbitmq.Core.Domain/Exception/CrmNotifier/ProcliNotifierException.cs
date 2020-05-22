using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CrmNotifier
{
    [Serializable]
    public class ProcliNotifierException : BaseException
    {
        public ProcliNotifierException()
        {
        }

        public ProcliNotifierException(string message) : base(message)
        {
        }

        public ProcliNotifierException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected ProcliNotifierException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

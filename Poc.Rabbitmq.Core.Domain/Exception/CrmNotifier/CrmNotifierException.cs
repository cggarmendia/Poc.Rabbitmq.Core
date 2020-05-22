using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CrmNotifier
{
    [Serializable]
    public class CrmNotifierException : BaseException
    {
        public CrmNotifierException()
        {
        }

        public CrmNotifierException(string message) : base(message)
        {
        }

        public CrmNotifierException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected CrmNotifierException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

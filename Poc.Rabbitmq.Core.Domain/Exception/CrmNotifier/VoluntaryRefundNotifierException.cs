using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CrmNotifier
{
    [Serializable]
    public class VoluntaryRefundNotifierException : BaseException
    {
        public VoluntaryRefundNotifierException()
        {
        }

        public VoluntaryRefundNotifierException(string message) : base(message)
        {
        }

        public VoluntaryRefundNotifierException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected VoluntaryRefundNotifierException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

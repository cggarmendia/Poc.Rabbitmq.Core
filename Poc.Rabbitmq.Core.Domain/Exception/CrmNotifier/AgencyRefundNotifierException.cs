using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CrmNotifier
{
    [Serializable]
    public class AgencyRefundNotifierException : BaseException
    {
        public AgencyRefundNotifierException()
        {
        }

        public AgencyRefundNotifierException(string message) : base(message)
        {
        }

        public AgencyRefundNotifierException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected AgencyRefundNotifierException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
using System;
using System.Runtime.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell
{

    [Serializable]
    public class PaymentRefundNotAllowedException : BaseException
    {
        public PaymentRefundNotAllowedException()
        {
        }

        public PaymentRefundNotAllowedException(string message) : base(message)
        {
        }

        public PaymentRefundNotAllowedException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected PaymentRefundNotAllowedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

}

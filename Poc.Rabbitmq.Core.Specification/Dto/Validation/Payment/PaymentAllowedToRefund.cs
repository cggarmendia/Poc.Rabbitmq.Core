using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Specification.Dto.Validation.Payment
{
    public class PaymentAllowedToRefundDto
    {
        public IEnumerable<string> PaymentMethodCodesAllowed { get; set; }
        public IEnumerable<string> PaymentMethodCodes { get; set; }
    }
}

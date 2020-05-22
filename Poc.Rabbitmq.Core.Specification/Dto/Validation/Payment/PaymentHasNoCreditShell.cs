using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Specification.Dto.Validation.Payment
{
    public class PaymentHasNoCreditShellDto
    {
        public IEnumerable<PaymentInfo> PaymentsInfo { get; set; }
        public IEnumerable<string> ValidPaymentMethodCodes { get; set; }
        public IEnumerable<string> AccountTransactionCodes { get; set; }
        public bool HasJourneys { get; set; }
    }


    public class PaymentInfo
    {
        public string PaymentMethod { get; set; }
        public string AccountTransactionCode { get; set; }
    }
}

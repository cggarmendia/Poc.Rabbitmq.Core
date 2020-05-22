using System;

namespace Poc.Rabbitmq.Core.Domain.Dto.CancelCreditShell
{
    public class CancelCreditShellDto
    {
        public string RecordLocator { get; set; }
        public string RefundIncrementCurrencyCode { get; set; }
        public string ProcessType { get; set; }
        public DateTime RequestRefundDate { get; set; }
        public decimal Amount { get; set; }
    }
}

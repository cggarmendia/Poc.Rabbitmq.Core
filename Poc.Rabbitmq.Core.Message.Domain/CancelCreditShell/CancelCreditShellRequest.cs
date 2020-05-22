using System;

namespace Poc.Rabbitmq.Core.Message.Domain.CancelCreditShell
{
    public class CancelCreditShellRequest
    {
        public string RecordLocator { get; set; }
        public decimal AmountToRefund { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime RequestRefundDate { get; set; }
        public string ExternalId { get; set; }
        public string OwnerCarrierCode { get; set; }
        public string ProcessType { get; set; }
    }



}

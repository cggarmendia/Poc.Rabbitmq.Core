using System;

namespace Poc.Rabbitmq.Core.Domain.Dto.CancelCreditShell
{
    public class CancelCreditShellResponse
    {
        public string RecordLocator { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string BookingId { get; set; }
        public decimal Amount { get; set; }
    }
}

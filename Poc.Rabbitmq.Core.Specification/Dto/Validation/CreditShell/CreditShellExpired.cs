using System;

namespace Poc.Rabbitmq.Core.Specification.Dto.Validation.CreditShell
{
    public class CreditShellExpiredDto
    {
        public DateTime RequestRefundDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}

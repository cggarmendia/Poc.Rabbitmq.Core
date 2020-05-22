using System;
using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.AccountManager
{
    public class AccountCreditShellDto
    {
        public decimal AvailableAmount { get; set; }

        public decimal OriginalAmount { get; set; }

        public DateTime ExpirationDate { get; set; }

        public List<string> References { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Domain.Configuration
{
    public interface IConfiguration
    {
        string AgentName { get; }
        string Password { get; }
        string DomainName { get; }
        string DefaultCulture { get; }
        DateTime ExpirationDate { get; }
        string Environment { get; set; }
        string ServiceDirectoryServiceUri { get; set; }
        string CreditShellPaymentMethodCode { get; }
        string IncrementPaymentMethodCode { get; }
        string RefundAgencyPaymentMethodCode { get; }
        int ContractVersion { get; }
        string CreditFilePaymentMethodCode { get; }
        decimal AmountMargin { get; }
        List<string> PaymentCodesAllowed { get; }
        string CrmPendingTransferFeeCode { get; }
    }
}

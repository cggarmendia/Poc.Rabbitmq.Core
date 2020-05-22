using System;
using System.Collections.Generic;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Payment
{
    public class PaymentDto
    {
        public long PaymentId { get; set; }
        public short ReferenceType { get; set; }
        public long ReferenceId { get; set; }
        public PaymentMethodType PaymentMethodType { get; set; }
        public string PaymentMethodCode { get; set; }
        public string CurrencyCode { get; set; }
        public decimal PaymentAmount { get; set; }
        public string CollectedCurrencyCode { get; set; }
        public decimal CollectedAmount { get; set; }
        public string QuotedCurrencyCode { get; set; }
        public decimal QuotedAmount { get; set; }
        public short Status { get; set; }
        public DateTime ApprovalDate { get; set; }
        public long AccountNumberId { get; set; }
        public string AccountNumber { get; set; }
        public int BinRange { get; set; }
        public DateTime Expiration { get; set; }
        public string AccountName { get; set; }
        public string AuthorizationCode { get; set; }
        public short AuthorizationStatus { get; set; }
        public long ParentPaymentId { get; set; }
        public bool Transferred { get; set; }
        public bool AmountOverride { get; set; }
        public bool RestrictionOverride { get; set; }
        public bool ReceiptPrinted { get; set; }
        public bool Deposit { get; set; }
        public DateTime FundedDate { get; set; }
        public short Installments { get; set; }
        public string PaymentText { get; set; }
        public string PaymentFields { get; set; }
        public short ChannelType { get; set; }
        public string CreatedAgentCode { get; set; }
        public string CreatedOrganizationCode { get; set; }
        public string CreatedDomainCode { get; set; }
        public string CreatedLocationCode { get; set; }
        public string SourceAgentCode { get; set; }
        public string SourceOrganizationCode { get; set; }
        public string SourceDomainCode { get; set; }
        public string SourceLocationCode { get; set; }
        public long CreatedAgentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long ModifiedAgentId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public List<AddressDto> Addresses { get; set; }
        public List<KeyValuePair<string, string>> PaymentFieldsList { get; set; }
        public short PaymentNumber { get; set; }
        public short State { get; set; }
        //public Guid DCCRateId { get; set; }
        //public short DCCStatus { get; set; }
        //public decimal DCCValidationDCCAmount { get; set; }
        //public bool DCCValidationDCCApplicable { get; set; }
        //public string DCCValidationDCCCurrency { get; set; }
        //public string DCCValidationDCCPutInState { get; set; }
        //public decimal DCCValidationDCCRateValue { get; set; }
    }
}

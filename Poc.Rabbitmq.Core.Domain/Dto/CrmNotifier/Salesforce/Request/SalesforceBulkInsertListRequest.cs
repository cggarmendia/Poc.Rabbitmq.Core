using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Domain.Dto.CrmNotifier.Salesforce.Request
{
    public class SalesforceBulkInsertListRequestDto : SalesforceRequestDto
    {
        public List<SalesforceBulkInsertRequestDto> RequestInsertParams { get; set; }

        public SalesforceBulkInsertListRequestDto()
        {
            RequestInsertParams = new List<SalesforceBulkInsertRequestDto>();
        }
    }

    public class SalesforceBulkInsertRequestDto
    {
        public string ClientType { get; set; }

        public string Type { get; set; }

        public string Service { get; set; }

        public string Description { get; set; }

        public string Culture { get; set; }

        public string OwnerCarrier { get; set; }

        public long BookingId { get; set; }

        public string RecordLocator { get; set; }

        public string RefundType { get; set; }

        public string RefundIncrementType { get; set; }

        public double RefundIncrementValue { get; set; }

        public string RefundIncrementCurrencyCode { get; set; }

        public AccountDto Account { get; set; }
    }

    public class AccountDto
    {
        public string IATACIF { get; set; }
    }
}
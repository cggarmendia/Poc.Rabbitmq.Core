using System;
using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Domain.Dto.CrmNotifier.Salesforce.Request
{
    public class SalesforceNotifyListRequestDto : SalesforceRequestDto
    {
        public List<SalesforceNotifyRequestDto> SalesforceNotifyList { get; set; }

    }

    public class SalesforceNotifyRequestDto
    {
        public string ExternalId { get; set; }
        public bool Result { get; set; }
        public string RefundType { get; set; }
        public string RefundCode { get; set; }
        public string RefundAmount { get; set; }
        public string RefundOriginalAmount { get; set; }
        public string RefundCurrencyCode { get; set; }
        public string RefundIncrementType { get; set; }
        public decimal RefundIncrementValue { get; set; }
        public string RefundIncrementCurrencyCode { get; set; }
        public DateTime RefundExpirationDate { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public List<FlightDto> Flights { get; set; }
    }

    public class FlightDto
    {
        public string InventoryLegId { get; set; }
        public string Carrier { get; set; }
        public string FlightNumber { get; set; }
        public DateTime FlightDateLT { get; set; }
        public string DepartureIATA { get; set; }
        public string ArrivalIATA { get; set; }
    }
}

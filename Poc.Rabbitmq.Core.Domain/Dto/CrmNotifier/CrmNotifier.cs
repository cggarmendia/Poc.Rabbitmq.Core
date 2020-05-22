using System;
using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Domain.Dto.CrmNotifier
{
    public class CrmNotifierDto
    {
        public string ContactFirstname { get; set; }
        public string ContactLastname { get; set; }
        public string CultureCode { get; set; }
        public string FlightArrivalIATA { get; set; }
        public string FlightDepartureIATA { get; set; }
        public DateTime FlightDateLT { get; set; }
        public string FlightNumber { get; set; }
        public string CarrierCode { get; set; }
        public long InventoryLegId { get; set; }
        public string RecordLocator { get; set; }
        public string BookingId { get; set; }
        public string Email { get; set; }
        public string ExternalId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public bool Result { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string RefundType { get; set; }
        public decimal RefundOriginalAmount { get; set; }
        public decimal RefundValue { get; set; }
        public string RefundCurrencyCode { get; set; }
        public string ProcessType { get; set; }
        public List<FlightProcessed> FlightProcessedList { get; set; }
    }

    public class FlightProcessed
    {
        public string ArrivalIATA { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureIATA { get; set; }
        public string Carrier { get; set; }
        public string InventoryLegId { get; set; }
        public bool Processed { get; set; }
        public DateTime FlightDateLT { get; set; }
    }
}

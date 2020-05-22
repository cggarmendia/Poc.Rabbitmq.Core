using System;

namespace Poc.Rabbitmq.Core.Message.Domain.Common
{
    public class FlightProcessedRequest
    {
        public string FlightArrivalIATA { get; set; }
        public string FlightNumber { get; set; }
        public string FlightDepartureIATA { get; set; }
        public string CarrierCode { get; set; }
        public string InventoryLegId { get; set; }
        public DateTime FlightDateLT { get; set; }
    }
}
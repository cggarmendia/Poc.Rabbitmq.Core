using System.Collections.Generic;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Payment;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common
{
    public class BookingDto
    {
        public SourcePOC SourcePOS;
        public List<PassengerDto> Passengers { get; set; }
        public List<JourneyDto> Journeys { get; set; }
        public string CurrencyCode { get; set; }
        public decimal BalanceDue { get; set; }
        public List<PaymentDto> Payments { get; set; }
        public string RecordLocator { get; set; }
    }
}

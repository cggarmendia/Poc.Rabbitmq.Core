using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common
{
    public class BookingDto
    {
        public List<PassengerDto> Passengers { get; set; }
        public List<JourneyDto> Journeys { get; set; }
        public string CurrencyCode { get; set; }
        public decimal BalanceDue { get; set; }
    }
}

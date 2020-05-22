using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common
{
    public class BookingDeltaDto
    {
        public List<PassengerDto> Passengers { get; set; }
    }
}

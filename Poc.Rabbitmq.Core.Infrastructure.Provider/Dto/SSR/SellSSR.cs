using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.SSR
{
    public class SellSSRDto
    {
        public BookingDto Booking { get; set; }
        public string SsrCode { get; set; }
        public short PassengerNumber { get; set; }
        public string SessionToken { get; set; }
    }
}

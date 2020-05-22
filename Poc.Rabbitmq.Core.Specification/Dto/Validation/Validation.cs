using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common;

namespace Poc.Rabbitmq.Core.Specification.Dto.Validation
{
    public class ValidationDto
    {
        public BookingDto Booking { get; set; }
        public decimal AmountToRefund { get; set; }
    }
}

namespace Poc.Rabbitmq.Core.Specification.Dto.Validation.Booking
{
    public class BookingBalanceDueDto
    {
        public decimal BalanceDue { get; set; }
        public decimal AmountToRefund { get; set; }
    }
}

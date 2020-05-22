namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Booking
{
    public class FeeRequestDto
    {
        public string MessageContext { get; set; }
        public int PassengerNumber { get; set; }
        public string SessionId { get; set; }
        public decimal NetAmount { get; set; }
        public short FeeNumber { get; set; }
        public string CurrencyCode { get; set; }
    }
}

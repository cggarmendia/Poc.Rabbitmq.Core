namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Booking
{
    public class SellPenaltyFeeRequestDto
    {
        public string FeeCode { get; set; }
        public string Note { get; set; }
        public string SessionId { get; set; }
        public string CollectedCurrencyCode { get; set; }
        public string MessageContext { get; set; }
        public string OriginatingStationCode { get; set; }
    }
}

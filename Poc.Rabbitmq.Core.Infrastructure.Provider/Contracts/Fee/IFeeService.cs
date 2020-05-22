namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Fee
{
    public interface IFeeService
    {
        void SellPenaltyFee(string currencyCode, string feeCode, short passengerNumber, string sessionToken, decimal feeAmount);
        void SellServiceFee(string currencyCode, string feeCode, string sessionToken, decimal feeAmount);
    }
}
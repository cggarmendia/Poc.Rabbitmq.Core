namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Payment
{
    public enum PaymentMethodType
    {
        Unmapped,
        PrePaid,
        ExternalAccount,
        AgencyAccount,
        CustomerAccount,
        Voucher,
        Loyalty,
    }
}
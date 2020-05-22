namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Payment
{
    public enum PaymentStatus
    {
        New,
        Received,
        Pending,
        Approved,
        Declined,
        Unknown,
        PendingCustomerAction,
    }
}

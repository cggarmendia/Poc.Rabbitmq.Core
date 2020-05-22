namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Payment
{
    public enum PaymentState
    {
        Unmapped,
        New,
        Clean,
        Modified,
        Deleted,
        Confirmed,
    }
}

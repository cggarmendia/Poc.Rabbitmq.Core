namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Booking
{
    public interface IBookingCommiter
    {
        void BookingCommit(string recordLocator, string comment, string comment2, string signature);
    }
}
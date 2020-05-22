using System;
using Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Booking;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Booking;

namespace Poc.Rabbitmq.Core.Infrastructure.ProviderZ.Booking
{
    public class BookingCommiter : IBookingCommiter
    {
        private const string ConcurrentCommitTextConst = "";

        #region Properties
        #endregion

        #region Ctor
        #endregion

        #region Public_Methods
        public void BookingCommit(string recordLocator, string comment, string comment2, string signature)
        {
            try
            {
                //ToDo
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains(ConcurrentCommitTextConst))
                {
                    var errorMessageConcurrentCommit =
                        $"Error in: {GetType().FullName}, method: BookingCommit, exception: ConcurrentCommitOperationException, message: {ex.Message}.";
                    throw new ConcurrentCommitOperationException(errorMessageConcurrentCommit, ex);
                }

                var errorMessageBookingCommit =
                    $"Error in: {GetType().FullName}, method: BookingCommit, exception: BookingCommitException, message: {ex.Message}.";
                throw new BookingCommitException(errorMessageBookingCommit);
            }
        }
        #endregion

        #region Private_Methods
        #endregion
    }
}

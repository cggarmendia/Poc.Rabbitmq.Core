using System;
using System.Collections.Generic;
using Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Booking;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Booking;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Booking;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common;

namespace Poc.Rabbitmq.Core.Infrastructure.ProviderZ.Booking
{
    public class BookingService : IBookingService
    {
        #region Properties
        #endregion

        #region Ctor
        #endregion

        #region Public_Methods
        public void SellSSR(SSRRequestDto ssrRequest)
        {
            //ToDo
        }

        public BookingDeltaDto SellPenaltyFee(SellPenaltyFeeRequestDto feeRequest)
        {
            //ToDO
            return new BookingDeltaDto();
        }

        public BookingDeltaDto SellSpoilageFee(SellSpoilageFeeRequestDto feeRequest)
        {
            //ToDO
            return new BookingDeltaDto();
        }

        public BookingDeltaDto SellServiceFee(SellServiceFeeRequestDto feeRequest)
        {
            //ToDO
            return new BookingDeltaDto();
        }

        public BookingDeltaDto OverrideFee(FeeRequestDto feeRequest)
        {
            //ToDO
            return new BookingDeltaDto();
        }

        public BookingDto GetPureBooking(string recordLocator, string signature)
        {
            try
            {
                //ToDo
                return new BookingDto();
            }
            catch (Exception ex)
            {
                var errorMessage =
                    $"Error in: {GetType().FullName}, method: GetPureBooking, exception: BookingByRecordLocatorException, message: {ex.Message}.";
                throw new BookingByRecordLocatorException(errorMessage);
            }
        }

        public BookingDto GetBooking(string recordLocator, string sessionToken)
        {
            try
            {
                //ToDo
                return new BookingDto();
            }
            catch (Exception ex)
            {
                var errorMessage =
                    $"Error in: {GetType().FullName}, method: GetBooking, exception: BookingByRecordLocatorException, message: {ex.Message}.";
                throw new BookingByRecordLocatorException(errorMessage);
            }
        }

        public decimal GetBalanceDueForTheUncommittedBookingCancel(string recordLocator, string sessionToken, IEnumerable<string> sellKeyList)
        {
            try
            {
                //ToDo
                return decimal.Zero;
            }
            catch (Exception ex)
            {
                var errorMessage =
                    $"Error in: {GetType().FullName}, method: GetBalanceDueForTheUncommittedBookingCancel, exception: BookingCancelException, message: {ex.Message}.";
                throw new BookingCancelException(errorMessage);
            }
        }
        #endregion

        #region Private_Methods


        #endregion
    }
}

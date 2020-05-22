using System.Collections.Generic;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Booking;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Booking
{
    public interface IBookingService
    {
        void SellSSR(SSRRequestDto ssrRequest);

        BookingDto GetBooking(string recordLocator,
            string sessionToken);

        decimal GetBalanceDueForTheUncommittedBookingCancel(string recordLocator, string sessionToken,
            IEnumerable<string> sellKeyList);

        BookingDto GetPureBooking(string recordLocator, string signature);

        BookingDeltaDto SellPenaltyFee(SellPenaltyFeeRequestDto feeRequest);

        BookingDeltaDto SellSpoilageFee(SellSpoilageFeeRequestDto feeRequest);

        BookingDeltaDto SellServiceFee(SellServiceFeeRequestDto feeRequest);

        BookingDeltaDto OverrideFee(FeeRequestDto feeRequest);
    }
}
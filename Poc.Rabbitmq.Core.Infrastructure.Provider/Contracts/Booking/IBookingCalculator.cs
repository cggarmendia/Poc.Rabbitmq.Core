using System.Collections.Generic;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Booking
{
    public interface IBookingCalculator
    {
        decimal GetRefundableTotalAmount(string recordLocator, List<string> sellKeyList);
        decimal GetBookingTotalAmount(BookingDto booking);
    }
}
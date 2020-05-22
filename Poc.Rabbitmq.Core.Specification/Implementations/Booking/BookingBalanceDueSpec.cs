using System;
using Poc.Rabbitmq.Core.Domain.Exception.BookingBalancer;
using Poc.Rabbitmq.Core.Specification.Contracts;
using Poc.Rabbitmq.Core.Specification.Dto.Validation.Booking;

namespace Poc.Rabbitmq.Core.Specification.Implementations.Booking
{
    public class BookingBalanceDueSpec : ISpecification<BookingBalanceDueDto>
    {
        public void IsValid(BookingBalanceDueDto dto)
        {
            if (Math.Abs(dto.BalanceDue) < dto.AmountToRefund)
            {
                throw new BookingBalanceDueException($"The booking does not have enough credit to refund, bookingCreditAvailable: {dto.BalanceDue}, amountToRefund: {dto.AmountToRefund}.");
            }
        }
    }
}

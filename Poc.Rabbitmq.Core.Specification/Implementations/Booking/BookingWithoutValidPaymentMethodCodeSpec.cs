using System.Linq;
using Poc.Rabbitmq.Core.Domain.Exception.BookingBalancer;
using Poc.Rabbitmq.Core.Specification.Contracts;
using Poc.Rabbitmq.Core.Specification.Dto.Validation.Booking;

namespace Poc.Rabbitmq.Core.Specification.Implementations.Booking
{
    public class BookingWithoutValidPaymentMethodCodeSpec : ISpecification<BookingWithoutValidPaymentMethodCodeDto>
    {
        public void IsValid(BookingWithoutValidPaymentMethodCodeDto dto)
        {
            if (!dto.ValidPaymentMethods.Intersect(dto.BookingPaymentMethods).Any())
            {
                throw new BookingWithoutValidPaymentMethodCodeException($"The booking does not have valid payment method code, bookingPaymentMethodCode: {string.Join(",", dto.BookingPaymentMethods.ToList())}");
            }
        }
    }
}

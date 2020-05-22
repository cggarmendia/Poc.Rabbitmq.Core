using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Specification.Dto.Validation.Booking
{
    public class BookingWithoutValidPaymentMethodCodeDto
    {
        public IEnumerable<string> BookingPaymentMethods { get; set; }
        public IEnumerable<string> ValidPaymentMethods { get; set; }
    }
}

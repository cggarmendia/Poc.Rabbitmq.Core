using System.Collections.Generic;
using System.Linq;
using Poc.Rabbitmq.Core.Domain.Exception.BookingBalancer;
using Poc.Rabbitmq.Core.Specification.Contracts;

namespace Poc.Rabbitmq.Core.Specification.Implementations.Payment
{
    public class PaymentWithNegativeAmountSpec : ISpecification<IEnumerable<decimal>>
    {
        public void IsValid(IEnumerable<decimal> dto)
        {
            if (dto.Any(validPaymentAmount => validPaymentAmount < 0))
                throw new PaymentWithNegativeAmountException($"Is not possible to refund a payment with negative amount. Payment amounts : {string.Join(",", dto.Select(validPaymentAmount => validPaymentAmount).ToList())}");
        }
    }
}

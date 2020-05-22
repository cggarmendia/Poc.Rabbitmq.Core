using Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell;
using Poc.Rabbitmq.Core.Specification.Contracts;

namespace Poc.Rabbitmq.Core.Specification.Implementations.Request
{
    public class RequestInvalidAmountSpec : ISpecification<decimal>
    {
        public void IsValid(decimal amount)
        {
            if (amount <= 0)
            {
                throw new RequestInvalidAmountException("Request with invalid amount");
            }
        }
    }
}

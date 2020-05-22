using Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell;
using Poc.Rabbitmq.Core.Specification.Contracts;

namespace Poc.Rabbitmq.Core.Specification.Implementations.Account
{
    public class AccountSoldOutSpec : ISpecification<decimal>
    {
        public void IsValid(decimal dto)
        {
            if (dto <= 0)
            {
                throw new SoldOutCreditShellException("Sold out creditShells.");
            }

        }



    }
}

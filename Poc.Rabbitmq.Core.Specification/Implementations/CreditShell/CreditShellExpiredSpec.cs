using Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell;
using Poc.Rabbitmq.Core.Specification.Contracts;
using Poc.Rabbitmq.Core.Specification.Dto.Validation.CreditShell;

namespace Poc.Rabbitmq.Core.Specification.Implementations.CreditShell
{
    public class CreditShellExpiredSpec : ISpecification<CreditShellExpiredDto>
    {
        public void IsValid(CreditShellExpiredDto dto)
        {
            if (dto.RequestRefundDate > dto.ExpirationDate)
            {
                throw new ExpiredCreditShellException("creditShell expired.");
            }
        }
    }
}

using System.Linq;
using Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell;
using Poc.Rabbitmq.Core.Specification.Contracts;
using Poc.Rabbitmq.Core.Specification.Dto.Validation.CreditShell;

namespace Poc.Rabbitmq.Core.Specification.Implementations.CreditShell
{
    public class CreditShellUsedSpec : ISpecification<CreditShellUsedDto>
    {
        public void IsValid(CreditShellUsedDto dto)
        {
            if (dto.References.Any(reference => !dto.Pnr.Equals(reference)))
            {
                throw new UsedCreditShellException("creditShell utilizado en otro Pnr.");
            }
                
        }
    }
}

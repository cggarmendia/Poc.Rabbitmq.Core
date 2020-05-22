using Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell;
using Poc.Rabbitmq.Core.Specification.Contracts;
using Poc.Rabbitmq.Core.Specification.Dto.Validation.CreditShell;

namespace Poc.Rabbitmq.Core.Specification.Implementations.CreditShell
{
    public class CreditShellWithAmountSpec : ISpecification<CreditShellWithAmountDto>
    {
        public void IsValid(CreditShellWithAmountDto dto)
        {
            if (!dto.CurrencyCode.Equals(dto.CrmCurrencyCode))
            {
                throw new IncorrectCurrencyCodeException("different currencyCode in creditShell.");
            }

            if(dto.CrmPaymentAmount > dto.AvailableAmount)
            {
                throw new CreditShellWithoutAmountException("different amount in creditShell.");
            }

        }
    }

}

using System.Linq;
using Poc.Rabbitmq.Core.Domain.Exception.CancelCreditShell;
using Poc.Rabbitmq.Core.Specification.Contracts;
using Poc.Rabbitmq.Core.Specification.Dto.Validation.Payment;

namespace Poc.Rabbitmq.Core.Specification.Implementations.Payment
{
    public class PaymentHasNoCreditShellSpec : ISpecification<PaymentHasNoCreditShellDto>
    {
        public void IsValid(PaymentHasNoCreditShellDto dto)
        {
            if (!dto.PaymentsInfo.Any(paymentInfo=> dto.ValidPaymentMethodCodes.Contains(paymentInfo.PaymentMethod) 
                                                    && dto.AccountTransactionCodes.Contains(paymentInfo.AccountTransactionCode)))
            {
                if (dto.HasJourneys)
                {
                    throw new NoCreditShellException("booking without creditshell with journeys.");
                }

                throw new NoCreditShellWithoutJourneysException("booking without creditshell whitout journeys.");

            }
               
        }
    }
}

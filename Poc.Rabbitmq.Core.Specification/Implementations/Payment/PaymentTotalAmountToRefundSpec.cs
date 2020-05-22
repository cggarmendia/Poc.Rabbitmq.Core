using Poc.Rabbitmq.Core.Domain.Exception.BookingBalancer;
using Poc.Rabbitmq.Core.Specification.Contracts;
using Poc.Rabbitmq.Core.Specification.Dto.Validation.Payment;

namespace Poc.Rabbitmq.Core.Specification.Implementations.Payment
{
    public class PaymentTotalAmountToRefundSpec : ISpecification<PaymentTotalAmountToRefundDto>
    {
        public void IsValid(PaymentTotalAmountToRefundDto dto)
        {
            if (dto.PaymentTotalAmountToRefund < dto.AmountToRefund)
                throw new PaymentTotalAmountToRefundException($"The booking does not have enough credit to refund with yours payments, paymentsToRefundSum: {dto.PaymentTotalAmountToRefund}, amountToRefund: {dto.AmountToRefund}");
        }
    }
}

using System.Collections.Generic;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Payment;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Payment
{
    public interface IPaymentService
    {
        AddPaymentResponseDto AddPayment(PaymentToBookingDto paymentToBookingParam);
        List<PaymentDto> GetValidPayments(List<PaymentDto> payments);
    }
}

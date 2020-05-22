using System;
using System.Collections.Generic;
using Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Payment;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Payment;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Payment;

namespace Poc.Rabbitmq.Core.Infrastructure.ProviderZ.Payment
{
    public class PaymentService : IPaymentService
    {
        #region Properties
        #endregion

        #region Ctors.
        #endregion

        #region Public_Methods
        public AddPaymentResponseDto AddPayment(PaymentToBookingDto paymentToBookingParam)
        {
            try
            {
                //ToDo
                return new AddPaymentResponseDto();
            }
            catch (Exception ex)
            {
                var errorMessage =
                    $"Error in: {GetType().FullName}, method: AddPayment, exception: AddPaymentException, message: {ex.Message}.";
                throw new AddPaymentException(errorMessage);
            }
        }

        public List<PaymentDto> GetValidPayments(List<PaymentDto> payments)
        {
            //Todo
            return new List<PaymentDto>();
        }
        #endregion

        #region Private_Methods

        #endregion
    }
}

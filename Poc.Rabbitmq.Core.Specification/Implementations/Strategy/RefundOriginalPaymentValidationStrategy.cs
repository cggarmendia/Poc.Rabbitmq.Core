using Poc.Rabbitmq.Core.Specification.Contracts;
using Poc.Rabbitmq.Core.Specification.Contracts.Factory;
using Poc.Rabbitmq.Core.Specification.Contracts.Strategy;
using Poc.Rabbitmq.Core.Specification.Dto.Validation;
using Poc.Rabbitmq.Core.Specification.Dto.Validation.Booking;
using Poc.Rabbitmq.Core.Specification.Implementations.Booking;

namespace Poc.Rabbitmq.Core.Specification.Implementations.Strategy
{
    public class RefundOriginalPaymentValidationStrategy : IValidationStrategy
    {
        #region Properties.
        private ISpecification<BookingBalanceDueDto> _bookingBalanceDueSpecification;
        #endregion

        #region Ctor.
        public RefundOriginalPaymentValidationStrategy(IValidationFactory validationFactory)
        {
            InitializeValidations(validationFactory);
        }

        #endregion

        #region Public_Methods
        private void InitializeValidations(IValidationFactory validationFactory)
        {
            _bookingBalanceDueSpecification =
                validationFactory.GetValidationSpec<BookingBalanceDueSpec, BookingBalanceDueDto>();
        }

        public void DoValidations(ValidationDto parameter)
        {
            _bookingBalanceDueSpecification.IsValid(new BookingBalanceDueDto()
            {
                AmountToRefund = parameter.AmountToRefund,
                BalanceDue = parameter.Booking.BalanceDue
            });
        }
        #endregion
    }
}

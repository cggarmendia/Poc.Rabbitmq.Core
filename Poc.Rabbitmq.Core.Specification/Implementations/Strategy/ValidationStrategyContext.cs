using Poc.Rabbitmq.Core.Domain.Configuration;
using Poc.Rabbitmq.Core.Domain.Constant;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Payment;
using Poc.Rabbitmq.Core.Specification.Contracts.Factory;
using Poc.Rabbitmq.Core.Specification.Contracts.Strategy;
using Poc.Rabbitmq.Core.Specification.Dto.Validation;

namespace Poc.Rabbitmq.Core.Specification.Implementations.Strategy
{
    public class ValidationStrategyContext : IValidationStrategyContext
    {
        #region Properties
        private IValidationStrategy ValidationStrategy { get; set; }
        private readonly IValidationFactory _validationFactory;
        private readonly IPaymentService _paymentService;
        private readonly IConfiguration _configuration;
        #endregion

        #region Ctor.
        public ValidationStrategyContext(IValidationFactory validationFactory, 
            IPaymentService paymentService, IConfiguration configuration)
        {
            _validationFactory = validationFactory;
            _paymentService = paymentService;
            _configuration = configuration;
        }
        #endregion

        #region Public_Methods
        public void SetStrategy(string processType)
        {
            if (processType.Equals(ProcessTypeConst.CancelCreditShell))
            {
                ValidationStrategy = _validationFactory.GetValidationStrategy<RefundOriginalPaymentValidationStrategy>(_validationFactory);
            }
            else if (processType.Equals(ProcessTypeConst.AgencyCancelAndAddPayment))
            {
                //
            }
            else if (processType.Equals(ProcessTypeConst.CreateVoluntary))
            {
                //
            }
            else if (processType.Equals(ProcessTypeConst.PROCLI))
            {
                //
            }
        }

        public void DoValidations(ValidationDto parameter)
        {
            ValidationStrategy.DoValidations(parameter);
        }
        #endregion
    }
}

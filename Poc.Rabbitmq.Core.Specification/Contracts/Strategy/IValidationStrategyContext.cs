using Poc.Rabbitmq.Core.Specification.Dto.Validation;

namespace Poc.Rabbitmq.Core.Specification.Contracts.Strategy
{
    public interface IValidationStrategyContext
    {
        void SetStrategy(string processType);
        void DoValidations(ValidationDto parameter);
    }
}
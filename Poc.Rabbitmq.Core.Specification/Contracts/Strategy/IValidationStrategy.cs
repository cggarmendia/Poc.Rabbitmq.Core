using Poc.Rabbitmq.Core.Specification.Dto.Validation;

namespace Poc.Rabbitmq.Core.Specification.Contracts.Strategy
{
    public interface IValidationStrategy
    {
        void DoValidations(ValidationDto parameter);
    }
}
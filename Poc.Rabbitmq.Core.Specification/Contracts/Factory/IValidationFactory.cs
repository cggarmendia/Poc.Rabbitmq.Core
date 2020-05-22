using Poc.Rabbitmq.Core.Specification.Contracts.Strategy;

namespace Poc.Rabbitmq.Core.Specification.Contracts.Factory
{
    public interface IValidationFactory
    {
        /// <summary>
        /// Get the validation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TParam">The type of the param.</typeparam>
        /// <returns></returns>
        T GetValidationSpec<T, TParam>() where T : class, ISpecification<TParam>;

        /// <summary>
        /// Get the validation Strategy.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TParam">The type of the param.</typeparam>
        /// <returns></returns>
        T GetValidationStrategy<T>(params object[] objects) where T : class, IValidationStrategy;
    }
}

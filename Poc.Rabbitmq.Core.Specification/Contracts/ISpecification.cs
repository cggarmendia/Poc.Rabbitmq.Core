namespace Poc.Rabbitmq.Core.Specification.Contracts
{
    public interface ISpecification <in T>
    {
        /// <summary>
        /// Determines if [is valid] [the specified dto].
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns>
        /// 	<c>exception</c> if [is invalid] [the specified dto]; otherwise, <c>anything</c>.
        /// </returns>
        void IsValid(T dto);
    }
}

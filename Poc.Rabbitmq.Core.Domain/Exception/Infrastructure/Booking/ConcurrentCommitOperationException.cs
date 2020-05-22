namespace Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Booking
{
    public class ConcurrentCommitOperationException : System.Exception
    {
        public ConcurrentCommitOperationException(string eMessage, System.Exception faultException) : base(eMessage, faultException)
        {
        }
    }
}

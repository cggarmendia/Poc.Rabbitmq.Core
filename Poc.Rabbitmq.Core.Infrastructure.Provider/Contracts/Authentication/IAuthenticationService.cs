using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Authentication;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Authentication
{
    public interface IAuthenticationService
    {
        SessionDto LogOn();
        void LogOut(SessionDto session);
    }
}

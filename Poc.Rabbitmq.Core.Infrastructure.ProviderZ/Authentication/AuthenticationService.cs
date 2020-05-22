using System;
using Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Authentication;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Authentication;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Authentication;

namespace Poc.Rabbitmq.Core.Infrastructure.ProviderZ.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public SessionDto LogOn()
        {
            try
            {
                //ToDo

                return new SessionDto();
            }
            catch (Exception ex)
            {
                var errorMessage =
                    $"Error in: {GetType().FullName}, method: LogOn, exception: AuthenticationException, message: {ex.Message}.";
                throw new AuthenticationException(errorMessage);
            }
        }

        public void LogOut(SessionDto session)
        {
            try
            {
                //ToDo
            }
            catch (Exception ex)
            {
                var errorMessage =
                    $"Error in: {GetType().FullName}, method: LogOut, exception: AuthenticationException, message: {ex.Message}.";
                throw new AuthenticationException(errorMessage);
            }
        }
    }
}

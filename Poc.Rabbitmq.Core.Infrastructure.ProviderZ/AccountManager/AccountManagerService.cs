using System;
using Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.AccountManager;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.AccountManager;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.AccountManager;

namespace Poc.Rabbitmq.Core.Infrastructure.ProviderZ.AccountManager
{
    public class AccountManagerService : IAccountManagerService
    {
        public AccountDto GetAccount(string signature, long accountId)
        {
            try
            {
                //ToDo
                return new AccountDto();
            }
            catch (Exception ex)
            {
                var errorMessage = $@"Error in: {GetType().FullName}, method : GetAccount, accountId: {accountId}, innerExceptionType: {ex.GetType()}, innerExceptionMessage: {ex.Message}";
                throw new GetAccountException(errorMessage, ex);
            }
        }

        public AccountDto GetAccountByReference(string signature, string currencyCode, string accountReference)
        {
            try
            {
                //ToDo
                return new AccountDto();
            }
            catch (Exception ex)
            {
                var errorMessage = $@"Error in: {GetType().FullName}, method : GetAccountByReference, accountReference: {accountReference}, innerExceptionType: {ex.GetType()}, innerExceptionMessage: {ex.Message}";
                throw new GetAccountByReferenceException(errorMessage, ex);
            }
        }

        public AccountCreditShellDto GetAccountCreditShellDto(string recordLocator, string sessionId, string currency)
        {
            var result = new AccountCreditShellDto();

            //ToDo

            return result;
         }
    }
}

using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.AccountManager;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.AccountManager
{
    public interface IAccountManagerService
    {
        AccountCreditShellDto GetAccountCreditShellDto(string recordLocator, string sessionId, string currency);

        AccountDto GetAccount(string signature, long accountId);

        AccountDto GetAccountByReference(string signature, string currencyCode, string accountReference);
    }
}

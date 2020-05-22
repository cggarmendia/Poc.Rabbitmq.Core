using System;
using System.Collections.Generic;
using Poc.Rabbitmq.Core.Domain.Exception.Infrastructure.Core;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Core;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Core;

namespace Poc.Rabbitmq.Core.Infrastructure.ProviderZ.Core
{
    public class CoreService : ICoreService
    {
        public List<AccountTransactionCodeDto> GetAccountTransactionCodes(CodeType codeType, string signature)
        {
            try
            {
                //ToDo
                return new List<AccountTransactionCodeDto>();
            }
            catch (Exception ex)
            {
                var errorMessage =
                    $"Error in: {GetType().FullName}, method: GetAccountTransactionCodes, exception: AccountTransactionCodeException, message: {ex.Message}.";
                throw new AccountTransactionCodeException(errorMessage);
            }
       }
    }
}

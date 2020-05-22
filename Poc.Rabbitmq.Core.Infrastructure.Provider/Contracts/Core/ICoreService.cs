using System.Collections.Generic;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Core;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.Core
{
    public interface ICoreService
    {
        List<AccountTransactionCodeDto> GetAccountTransactionCodes(CodeType codeType, string signature);
    }
}

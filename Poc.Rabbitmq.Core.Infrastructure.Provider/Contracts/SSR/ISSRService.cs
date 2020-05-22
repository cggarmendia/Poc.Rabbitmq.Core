using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.SSR;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.SSR
{
    public interface ISSRService
    {
        void SellSSR(SellSSRDto dto);
    }
}

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.ComponentFactory
{
    public interface IComponentFactory
    {
        T GetComponent<T>() where T : class;
    }
}

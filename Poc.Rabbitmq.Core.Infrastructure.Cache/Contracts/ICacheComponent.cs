namespace Poc.Rabbitmq.Core.Infrastructure.Cache.Contracts
{
    public interface ICacheComponent
    {
        void TryAdd<T>(string key, T value);
        T TryGetValue<T>(string key);
        bool ContainsKey(string key);
    }
}
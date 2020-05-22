using System.Collections.Concurrent;
using Poc.Rabbitmq.Core.Infrastructure.Cache.Contracts;

namespace Poc.Rabbitmq.Core.Infrastructure.Cache.Implementations
{
    public class MemoryCache : ICacheComponent
    {
        public MemoryCache()
        {
            _cache = new ConcurrentDictionary<string, object>();
        }
        private readonly ConcurrentDictionary<string, object> _cache;

        public void TryAdd<T>(string key, T value)
        {
            _cache.TryAdd(key, value);
        }
        public T TryGetValue<T>(string key)
        {
            _cache.TryGetValue(key, out var value);
            return (T)value;
        }
        public bool ContainsKey(string key)
        {
            return _cache.ContainsKey(key);
        }
    }
}

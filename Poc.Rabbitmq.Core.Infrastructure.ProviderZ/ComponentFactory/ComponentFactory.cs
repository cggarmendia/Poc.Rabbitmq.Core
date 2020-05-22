using System;
using Poc.Rabbitmq.Core.Infrastructure.Cache.Contracts;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Contracts.ComponentFactory;

namespace Poc.Rabbitmq.Core.Infrastructure.ProviderZ.ComponentFactory
{
    public class ComponentFactory : IComponentFactory
    {
        private readonly ICacheComponent _cacheComponent;

        public ComponentFactory(ICacheComponent cacheComponent)
        {
            _cacheComponent = cacheComponent;
        }

        public T GetComponent<T>() where T : class
        {
            var name = typeof(T).FullName;
            if (_cacheComponent.ContainsKey(name))
            {
                return _cacheComponent.TryGetValue<T>(name);
            }

            var component = CreateComponentByAbstractFactory<T>();
            if (component != null)
            {
                _cacheComponent.TryAdd(name, component);
            }

            return component;
        }

        private T CreateComponentByAbstractFactory<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}

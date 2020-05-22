using System;
using System.Linq;
using System.Threading;
using Poc.Rabbitmq.Core.Infrastructure.Cache.Contracts;
using Poc.Rabbitmq.Core.Specification.Contracts;
using Poc.Rabbitmq.Core.Specification.Contracts.Factory;
using Poc.Rabbitmq.Core.Specification.Contracts.Strategy;

namespace Poc.Rabbitmq.Core.Specification.Implementations.Factory
{
    public class ValidationFactory : IValidationFactory
    {
        private readonly ICacheComponent _cacheComponent;
        private readonly Mutex _mutex;

        public ValidationFactory(ICacheComponent cacheComponent)
        {
            _cacheComponent = cacheComponent;
            _mutex = new Mutex();
        }

        public T GetValidationSpec<T, TParam>() where T : class, ISpecification<TParam>
        {
            var validationName = typeof(T).FullName;

            var validationInstance = default(T);

            if (_cacheComponent.ContainsKey(validationName))
            {
                validationInstance = _cacheComponent.TryGetValue<T>(validationName);
            }
            else
            {
                try
                {
                    if (_mutex.WaitOne())
                    {
                        var constructorInfo = typeof(T).GetConstructor(Type.EmptyTypes);
                        if (constructorInfo != null)
                        {
                            validationInstance = (T)constructorInfo.Invoke(null);

                            if (!_cacheComponent.ContainsKey(validationName))
                                _cacheComponent.TryAdd(validationName, validationInstance);
                        }
                    }
                }
                finally
                {
                    _mutex.ReleaseMutex();
                }
            }

            return validationInstance;
        }

        public T GetValidationStrategy<T>(params object[] objects) where T : class, IValidationStrategy
        {
            var validationName = typeof(T).FullName;

            var validationInstance = default(T);

            if (_cacheComponent.ContainsKey(validationName))
            {
                validationInstance = _cacheComponent.TryGetValue<T>(validationName);
            }
            else
            {
                try
                {
                    if (_mutex.WaitOne())
                    {
                        var constructorInfo = typeof(T).GetConstructor(objects.Select(objectInstance => objectInstance.GetType()).ToArray());
                        if (constructorInfo != null)
                        {
                            validationInstance = (T)constructorInfo.Invoke(objects);

                            if (!_cacheComponent.ContainsKey(validationName))
                                _cacheComponent.TryAdd(validationName, validationInstance);
                        }
                    }
                }
                finally
                {
                    _mutex.ReleaseMutex();
                }
            }

            return validationInstance;
        }
    }
}

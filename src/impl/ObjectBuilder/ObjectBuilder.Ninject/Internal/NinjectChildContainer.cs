namespace NServiceBus.ObjectBuilder.Ninject.Internal
{
    using System;
    using System.Collections.Generic;
    using global::Ninject;
    using global::Ninject.Extensions.NamedScope;
    using global::Ninject.Syntax;
    using NServiceBus.ObjectBuilder.Common;

    public class NinjectChildContainer : DisposeNotifyingObject, IContainer
    {
        private readonly IResolutionRoot resolutionRoot;

        public NinjectChildContainer(IResolutionRoot resolutionRoot)
        {
            this.resolutionRoot = resolutionRoot;
        }

        public object Build(Type typeToBuild)
        {
            return this.resolutionRoot.Get(typeToBuild);
        }

        public IEnumerable<object> BuildAll(Type typeToBuild)
        {
            return this.resolutionRoot.GetAll(typeToBuild);
        }

        public IContainer BuildChildContainer()
        {
            throw new NotImplementedException();
        }

        public void Configure(Type component, DependencyLifecycle dependencyLifecycle)
        {
            throw new NotImplementedException();
        }

        public void Configure<T>(Func<T> component, DependencyLifecycle dependencyLifecycle)
        {
            throw new NotImplementedException();
        }

        public void ConfigureProperty(Type component, string property, object value)
        {
            throw new NotImplementedException();
        }

        public void RegisterSingleton(Type lookupType, object instance)
        {
            throw new NotImplementedException();
        }

        public bool HasComponent(Type componentType)
        {
            throw new NotImplementedException();
        }

        public void Release(object instance)
        {
            throw new NotImplementedException();
        }
    }
}
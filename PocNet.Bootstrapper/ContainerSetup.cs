using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using PocNet.Standard.Repos;
using System;
using System.Reflection;

namespace PocNet.Bootstrapper
{
    public static class ContainerSetup
    {
        public static IServiceProvider InitializeWeb(Assembly webAssembly, IServiceCollection services) =>
            new AutofacServiceProvider(BaseAutofacInitialization(setupAction =>
            {
                setupAction.Populate(services);
                setupAction.RegisterAssemblyTypes(webAssembly).AsImplementedInterfaces();
            }));

        public static IContainer BaseAutofacInitialization(Action<ContainerBuilder> setupAction = null)
        {
            var builder = new ContainerBuilder();

           // builder.RegisterType<Infra.NetFramework.Message>().As<IMessage>().AsImplementedInterfaces();
            builder.RegisterType<infra.Core.Message>().As<IMessage>().AsImplementedInterfaces();
            setupAction?.Invoke(builder);
            return builder.Build();
        }
    }
}

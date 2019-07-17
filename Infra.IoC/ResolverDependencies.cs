using Common;
using Domain.Model.Events;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.IoC
{
    public class ResolverDependencies
    {
        public ServiceProvider Resolve()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IEventHandling<UserRegistered>, UserRegisteredHandlerSendEmail>();
            serviceCollection.AddTransient<IEventHandling<UserRegistered>, UserRegisteredHandlerSMS>();


            return serviceCollection.BuildServiceProvider();
        }
    }
}

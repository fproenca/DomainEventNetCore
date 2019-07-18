using System;
using Common;
using Domain.Model.Entities;
using Domain.Model.Events;
using Infra.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace DomainEventNetCore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin Console.");

            var container = new ResolverDependencies().Resolve();
            
            DomainEvents.Container = new DomainEventsContainer(container);
            
            var user = new User("Francisco", "franciscoproenca87@gmai.com");
            
            var userRegistered = new UserRegistered(1, 2, user);

            DomainEvents.Raise(userRegistered);

            Console.WriteLine("End Console.");

            Console.ReadKey();
        }
    }
}

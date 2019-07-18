using Common;
using System;
using System.Threading;

namespace Domain.Model.Events
{
    public class UserRegisteredHandlerSendEmail : IEventHandling<UserRegistered>
    {
        public void Handler(UserRegistered args)
        {
            Thread.Sleep(7000);
            // Send Email
            Console.WriteLine($"send email to {args._user.Name}");
            throw new Exception("test error");
        }
    }
}

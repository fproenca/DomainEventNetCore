using Common;
using System;

namespace Domain.Model.Events
{
    public class UserRegisteredHandlerSendEmail : IEventHandling<UserRegistered>
    {
        public void Handler(UserRegistered args)
        {
            // Send Email
            Console.WriteLine($"send email to {args._user.Name}");
        }
    }
}

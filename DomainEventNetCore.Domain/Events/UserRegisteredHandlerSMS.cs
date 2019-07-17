using Common;
using System;

namespace Domain.Model.Events
{
    public class UserRegisteredHandlerSMS : IEventHandling<UserRegistered>
    {
        public void Handler(UserRegistered args)
        {
            // Send Email
            Console.WriteLine($"send sms to {args._user.Name}");
        }
    }
}

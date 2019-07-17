using Common;
using Domain.Model.Entities;
using System;

namespace Domain.Model.Events
{
    public struct UserRegistered : IDomainEvent
    {
        public DateTime DateOccurred { get; }

        public readonly int _userId;
        public readonly int _userMadeRegisteredId;
        public readonly User _user;
        
        public UserRegistered(int userId, int userMadeRegisteredId, User user)
        {
            _userId = userId;
            _userMadeRegisteredId = userMadeRegisteredId;
            _user = user;
            DateOccurred = DateTime.Now;
        }

    }
}

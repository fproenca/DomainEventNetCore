﻿namespace Common
{
    public interface IEventHandling<T> where T : IDomainEvent
    {
        void Handler(T args);
    }
}

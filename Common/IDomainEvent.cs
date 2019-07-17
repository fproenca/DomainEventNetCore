using System;

namespace Common
{
    public interface IDomainEvent
    {
        DateTime DateOccurred { get; }
    }
}
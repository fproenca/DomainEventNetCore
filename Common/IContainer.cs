using System;
using System.Collections.Generic;

namespace Common
{
    public interface IContainer
    {
        object GetService(Type serviceType);
        IEnumerable<object> GetServices(Type serviceType);
    }
}

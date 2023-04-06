using System;

namespace IOC.web.Models
{
    public interface IDateService
    {
        DateTime GetDateTime { get; }
    }

    interface ISingletonDateService : IDateService { }
    interface IScopedDateService : IDateService { }
    interface ITransientDateService : IDateService { }
}

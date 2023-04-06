using System;

namespace IOC.web.Models
{
    public class DateService : ISingletonDateService, IScopedDateService, ITransientDateService
    {
        public DateTime GetDateTime { get; } = DateTime.Now;
    }


}

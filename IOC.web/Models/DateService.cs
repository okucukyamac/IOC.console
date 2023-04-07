using Microsoft.Extensions.Logging;
using System;

namespace IOC.web.Models
{
    public class DateService : ISingletonDateService, IScopedDateService, ITransientDateService
    {
        private readonly ILogger<DateService> _logger;
        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;
            _logger.LogWarning("DATESERVİCE CONSTRUCTORA GİRDİ");
        }
        public DateTime GetDateTime { get; } = DateTime.Now;
    }


}
 
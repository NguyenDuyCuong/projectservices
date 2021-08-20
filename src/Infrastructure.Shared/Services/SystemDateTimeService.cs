using ProjectServices.Application.Interfaces.Services;
using System;

namespace ProjectServices.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
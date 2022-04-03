using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodaTime;
using NodaTime.TimeZones;

namespace NodaTimeDemo
{

    public class ClockService : IClockService
    {
        private readonly IClock _clock;

        public DateTimeZone TimeZone { get; private set; }

        public ClockService()
            : this(SystemClock.Instance)
        {
        }

        public ClockService(IClock clock)
        {
            _clock = clock;

            // NOTE: Get the current users timezone here instead of hard coding it...
            TimeZone = DateTimeZoneProviders.Tzdb.GetZoneOrNull("Asia/Dhaka");
        }

        public Instant Now
            => _clock.GetCurrentInstant();

        public LocalDateTime LocalNow
            => Now.InZone(TimeZone).LocalDateTime;

        public Instant? ToInstant(LocalDateTime? local)
            => local?.InZone(TimeZone, Resolvers.LenientResolver).ToInstant();

        public LocalDateTime? ToLocal(Instant? instant)
            => instant?.InZone(TimeZone).LocalDateTime;
    }


}

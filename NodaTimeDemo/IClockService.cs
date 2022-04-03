using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodaTime;

namespace NodaTimeDemo
{
    public interface IClockService
    {
        DateTimeZone TimeZone { get; }

        Instant Now { get; }

        LocalDateTime LocalNow { get; }

        Instant? ToInstant(LocalDateTime? local);

        LocalDateTime? ToLocal(Instant? instant);
    }
}

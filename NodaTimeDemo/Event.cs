using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodaTime;

namespace NodaTimeDemo
{
    internal class Event
    {

        public LocalDateTime? Start { get; set; }
        public LocalDateTime? End { get; set; }
    
       

        public Instant Created { get; set; }
        public string CreatedBy { get; set; }

        public Instant? Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}

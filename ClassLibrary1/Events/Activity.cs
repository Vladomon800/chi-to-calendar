using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarLib
{
    public class Activity : Event
    {
        public string Description = "";
        public string Location = "";
        public DateTime EndDateTime;
        public TimeZoneInfo TimeZone;
        public DateTime? AtDeleted { get; }
        public bool IsDeleted;
    }
}

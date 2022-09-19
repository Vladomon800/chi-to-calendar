using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarLib
{
    public class ActivityCalendar : Calendar<Activity>
    {
        public static TimeZoneInfo DefaultTimeZone;
        public string Description;
        public TimeZoneInfo TimeZone = DefaultTimeZone;
        public ActivityCalendar(string name) : base(name) { }

        public override Activity[] GetEventsByDate(DateTime start, DateTime? end = null)
        {
            return base.GetEventsByDate(start, end).ToList().Where(activity => !activity.IsDeleted).ToArray();
        }

        public Activity[] GetDeletedActivitiesFromBin()
        {
            throw new NotImplementedException();
        }

        public void DeleteFromBin(Activity activity)
        {
            throw new NotImplementedException();
        }
    }
}

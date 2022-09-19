using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalendarLib;

namespace UnitTestProject1
{
    [TestClass]
    public class CreateNewCalendars
    {
        [TestMethod]
        public void CNC_1()
        {
            string title = "Тест";
            string description = "Описание теста";
            TimeZoneInfo timezone = TimeZoneInfo.GetSystemTimeZones()[4];

            Application app = Application.GetApplication();

            var calendars = app.GetCalendarsWithActivities();
            
            int calendars_len = calendars.Length;

            app.AddCalendar(new ActivityCalendar(title) { Description = description, TimeZone = timezone});
            calendars = app.GetCalendarsWithActivities();
            var calendar = calendars[calendars_len];

            Assert.IsTrue(calendars.Length > 0, "Должен существовать хотя бы один календарь");
            Assert.AreEqual(calendars_len + 1, calendars.Length, "Несоответствие количества календарей");
            Assert.AreEqual(title, calendar.Title, "Несоответствие имени календаря");
            Assert.AreEqual(description, calendar.Description, "Несоответствие описания календаря");
            Assert.AreEqual(timezone, calendar.TimeZone, "Несоответствие часового пояса календаря");
        }

        [TestMethod]
        public void CNC_2()
        {
            string title = "Тест";
            string description = "";
            TimeZoneInfo timezone = TimeZoneInfo.Local;

            Application app = Application.GetApplication();

            var calendars = app.GetCalendarsWithActivities();

            int calendars_len = calendars.Length;

            app.AddCalendar(new ActivityCalendar(title) { Title = title, Description = description, TimeZone = timezone });
            calendars = app.GetCalendarsWithActivities();
            var calendar = calendars[calendars_len];

            Assert.IsTrue(calendars.Length > 0, "Должен существовать хотя бы один календарь");
            Assert.AreEqual(calendars_len + 1, calendars.Length, "Несоответствие количества календарей");
            Assert.AreEqual(title, calendar.Title, "Несоответствие имени календаря");
            Assert.AreEqual(description, calendar.Description, "Несоответствие описания календаря");
            Assert.AreEqual(timezone, calendar.TimeZone, "Несоответствие часового пояса календаря");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Недопустимое название календаря")]
        public void CNC_3()
        {
            string title = "";
            string description = "";
            TimeZoneInfo timezone = TimeZoneInfo.Local;

            Application app = Application.GetApplication();

            var calendars = app.GetCalendarsWithActivities();

            app.AddCalendar(new ActivityCalendar(title) { Title = title, Description = description, TimeZone = timezone });

            Assert.IsTrue(calendars.Length > 0, "Должен существовать хотя бы один календарь");
        }
    }
}

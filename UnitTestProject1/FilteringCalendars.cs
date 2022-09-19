using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalendarLib;

namespace UnitTestProject1
{
    [TestClass]
    public class FilteringCalendars
    {
        [TestMethod]
        public void FL_1()
        {
            Application app = Application.GetApplication();

            var calendars = app.GetCalendarsWithActivities();

            Activity activity = new Activity() { Title = "Тест", StartDateTime = DateTime.Now, EndDateTime = (DateTime.Now).AddDays(1) };
            calendars[0].AddEvent(activity);

            calendars[0].Visible = false;

            Assert.AreEqual(calendars[0].Visible, false, "Ожидалось, что календарь скрыт");
        }

        [TestMethod]
        public void FL_2()
        {
            Application app = Application.GetApplication();

            var calendars = app.GetCalendarsWithTasks();

            Task task = new Task() { Title = "Тест", StartDateTime = DateTime.Now };
            calendars[0].AddEvent(task);

            calendars[0].Visible = false;

            Assert.AreEqual(calendars[0].Visible, false, "Ожидалось, что календарь скрыт");
        }

        [TestMethod]
        public void FL_3()
        {
            Application app = Application.GetApplication();

            var calendar = app.GetCalendarWithReminders();

            Reminder reminder = new Reminder() { Title = "тест", StartDateTime = DateTime.Now};
            calendar.AddEvent(reminder);
            
            calendar.Visible = false;

            Assert.AreEqual(calendar.Visible, false, "Ожидалось, что календарь скрыт");
        }
    }
}

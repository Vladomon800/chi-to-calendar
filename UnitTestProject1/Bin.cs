using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalendarLib;

namespace UnitTestProject1
{
    [TestClass]
    public class Bin
    {
        [TestMethod]
        public void B_1()
        {
            Application application = Application.GetApplication();
            ActivityCalendar[] calendars = application.GetCalendarsWithActivities();

            DateTime sdt = DateTime.Now;
            Activity activity = new Activity()
            {
                Title = "B_1",
                StartDateTime = sdt,
                EndDateTime = sdt.AddDays(1)
            };
            calendars[0].AddEvent(activity);
            Activity[] events = calendars[0].GetEventsByDate(sdt);
            bool finded = Array.IndexOf(events, activity) != -1;
            Assert.AreEqual(true, finded, "Мероприятие не создано!");

            activity.IsDeleted = true;
            events = calendars[0].GetEventsByDate(sdt);
            finded = Array.IndexOf(events, activity) != -1;
            Assert.AreEqual(false, finded, "Мероприятие не удалено!");
        }

        [TestMethod]
        public void B_2()
        {
            Application application = Application.GetApplication();
            ActivityCalendar[] calendars = application.GetCalendarsWithActivities();

            DateTime sdt = DateTime.Now;
            Activity activity = new Activity()
            {
                Title = "B_2",
                StartDateTime = sdt,
                EndDateTime = sdt.AddDays(1)
            };
            calendars[0].AddEvent(activity);
            Activity[] events = calendars[0].GetEventsByDate(sdt);
            bool finded = Array.IndexOf(events, activity) != -1;
            Assert.AreEqual(true, finded, "Мероприятие не создано!");

            activity.IsDeleted = true;
            events = calendars[0].GetEventsByDate(sdt);
            finded = Array.IndexOf(events, activity) != -1;
            Assert.AreEqual(false, finded, "Мероприятие не удалено!");

            activity.IsDeleted = false;
            events = calendars[0].GetEventsByDate(sdt);
            finded = Array.IndexOf(events, activity) != -1;
            Assert.AreEqual(true, finded, "Мероприятия не существует!");
        }

        [TestMethod]
        public void B_3()
        {
            Application application = Application.GetApplication();
            ActivityCalendar[] calendars = application.GetCalendarsWithActivities();

            DateTime sdt = DateTime.Now;
            Activity activity = new Activity()
            {
                Title = "B_3",
                StartDateTime = sdt,
                EndDateTime = sdt.AddDays(1)
            };
            calendars[0].AddEvent(activity);
            Activity[] events = calendars[0].GetEventsByDate(sdt);
            bool finded = Array.IndexOf(events, activity) != -1;
            Assert.AreEqual(true, finded, "Мероприятие не создано!");

            activity.IsDeleted = true;
            events = calendars[0].GetEventsByDate(sdt);
            finded = Array.IndexOf(events, activity) != -1;
            Assert.AreEqual(false, finded, "Мероприятие не удалено!");

            calendars[0].DeleteFromBin(activity);
            Activity[] deletedactivites = calendars[0].GetDeletedActivitiesFromBin();
            finded = Array.IndexOf(deletedactivites, activity) != -1;
            Assert.AreEqual(false, finded, "Мероприятие не удалено из корзины!");
        }
    }
}

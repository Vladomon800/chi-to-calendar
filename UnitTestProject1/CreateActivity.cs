using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalendarLib;

namespace UnitTestProject1
{
    [TestClass]
    public class CreateActivity
    {
        [TestMethod]
        public void CM_1()
        {
            Application app = Application.GetApplication();

            Calendar<Activity>[] calendars = app.GetCalendarsWithActivities();
            var calendar = calendars[0];

            string name = "Встреча";
            DateTime startdatetime = DateTime.Now;
            DateTime enddatetime = startdatetime.AddDays(1);
            Activity activity = new Activity() { Title = name, StartDateTime = startdatetime, EndDateTime = enddatetime, TimeZone = TimeZoneInfo.Local};
            calendar.AddEvent(activity);

            Activity[] activitys = calendar.GetEventsByDate(startdatetime);

            bool finded = Array.IndexOf(activitys, activity) != -1;

            Assert.IsTrue(finded, "Созданное мероприятие не найдено в календаре");
            Assert.AreEqual(name, activity.Title, "Имена не совпадают");
            Assert.AreEqual(startdatetime, activity.StartDateTime, "Время окончания не совпадает");
            Assert.AreEqual(enddatetime, activity.EndDateTime, "Время начала не совпадает");
            Assert.AreEqual(TimeZoneInfo.Local, activity.TimeZone, "Часовой пояс не совпадает");
            Assert.AreEqual(false, activity.WholeDay, "Ожидалось что мероприятие будет проходить весь день");
        }

        [TestMethod]
        public void CM_2()
        {
            Application app = Application.GetApplication();

            Calendar<Activity>[] calendars = app.GetCalendarsWithActivities();
            var calendar = calendars[0];

            string name = "";
            DateTime startdatetime = DateTime.Now;
            DateTime enddatetime = startdatetime.AddDays(1);

            Activity activity = new Activity() { Title = name, StartDateTime = startdatetime, EndDateTime = enddatetime, TimeZone = TimeZoneInfo.Local };
            calendar.AddEvent(activity);

            Activity[] activitys = calendar.GetEventsByDate(startdatetime);

            bool finded = Array.IndexOf(activitys, activity) != -1;

            Assert.IsTrue(finded, "Созданное мероприятие не найдено в календаре");
            Assert.AreEqual(name, activity.Title, "Имена не совпадают");
            Assert.AreEqual(startdatetime, activity.StartDateTime, "Время окончания не совпадает");
            Assert.AreEqual(enddatetime, activity.EndDateTime, "Время начала не совпадает");
            Assert.AreEqual(TimeZoneInfo.Local, activity.TimeZone, "Часовой пояс не совпадает");
            Assert.AreEqual(false, activity.WholeDay, "Ожидалось что мероприятие будет проходить весь день");
        }

        [TestMethod]
        public void CM_3()
        {
            Application app = Application.GetApplication();

            Calendar<Activity>[] calendars = app.GetCalendarsWithActivities();
            var calendar = calendars[0];

            string name = "";
            DateTime currentdatetime = DateTime.Now;
            DateTime startdatetime = currentdatetime.AddDays(-1);
            DateTime enddatetime = currentdatetime.AddDays(1);

            Activity activity = new Activity() { Title = name, StartDateTime = startdatetime, EndDateTime = enddatetime, TimeZone = TimeZoneInfo.Local };
            calendar.AddEvent(activity);

            Activity[] activities = calendar.GetEventsByDate(startdatetime);

            bool finded = Array.IndexOf(activities, activity) != -1;

            Assert.IsTrue(finded, "Созданное мероприятие не найдено в календаре");
            Assert.AreEqual(name, activity.Title, "Имена не совпадают");
            Assert.AreEqual(startdatetime, activity.StartDateTime, "Время начала не совпадает");
            Assert.AreEqual(enddatetime, activity.EndDateTime, "Время окончания не совпадает");
            Assert.AreEqual(TimeZoneInfo.Local, activity.TimeZone, "Часовой пояс не совпадает");
            Assert.AreEqual(false, activity.WholeDay, "Ожидалось что мероприятие будет проходить весь день");
        }

        [TestMethod]
        public void CM_4()
        {
            Application app = Application.GetApplication();

            Calendar<Activity>[] calendars = app.GetCalendarsWithActivities();
            var calendar = calendars[0];

            string name = "";
            DateTime startdatetime = DateTime.Today;
            DateTime enddatetime = startdatetime.AddDays(1);
            bool wholeday = true;

            Activity activity = new Activity() { Title = name, StartDateTime = startdatetime, EndDateTime = enddatetime, WholeDay = wholeday, TimeZone = TimeZoneInfo.Local };
            calendar.AddEvent(activity);

            Activity[] activitys = calendar.GetEventsByDate(startdatetime);

            bool finded = Array.IndexOf(activitys, activity) != -1;

            Assert.IsTrue(finded, "Созданное мероприятие не найдено в календаре");
            Assert.AreEqual(name, activity.Title, "Имена не совпадают");
            Assert.AreEqual(startdatetime, activity.StartDateTime, "Время началане совпадает");
            Assert.AreEqual(enddatetime, activity.EndDateTime, "Время окончания не совпадает");
            Assert.AreEqual(TimeZoneInfo.Local, activity.TimeZone, "Часовой пояс не совпадает");
            Assert.AreEqual(wholeday, activity.WholeDay, "Ожидалось что мероприятие будет проходить весь день");
        }

        [TestMethod]
        public void CM_5()
        {
            Application app = Application.GetApplication();

            Calendar<Activity>[] calendars = app.GetCalendarsWithActivities();
            var calendar = calendars[0];

            string name = "Встреча";
            string location = "с червями";
            DateTime startdatetime = DateTime.Now;
            DateTime enddatetime = startdatetime.AddDays(1);
            Activity activity = new Activity() { Title = name, StartDateTime = startdatetime, EndDateTime = enddatetime, Location = location, TimeZone = TimeZoneInfo.Local };
            calendar.AddEvent(activity);

            Activity[] activitys = calendar.GetEventsByDate(startdatetime);

            bool finded = Array.IndexOf(activitys, activity) != -1;

            Assert.IsTrue(finded, "Созданное мероприятие не найдено в календаре");
            Assert.AreEqual(name, activity.Title, "Имена не совпадают");
            Assert.AreEqual(startdatetime, activity.StartDateTime, "Время начала не совпадает");
            Assert.AreEqual(enddatetime, activity.EndDateTime, "Время окончания не совпадает");
            Assert.AreEqual(TimeZoneInfo.Local, activity.TimeZone, "Часовой пояс не совпадает");
            Assert.AreEqual(location, activity.Location, "Место проведения не совпадает");
            Assert.AreEqual(false, activity.WholeDay, "Не ожидалось что мероприятие будет проходить весь день");
        }

        [TestMethod]
        public void CM_6()
        {
            Application app = Application.GetApplication();

            Calendar<Activity>[] calendars = app.GetCalendarsWithActivities();
            var calendar = calendars[0];

            string name = "Встреча";
            string description = "описание";
            DateTime startdatetime = DateTime.Now;
            DateTime enddatetime = startdatetime.AddDays(1);
            Activity activity = new Activity() { Title = name, Description = description, StartDateTime = startdatetime, EndDateTime = enddatetime, TimeZone = TimeZoneInfo.Local };
            calendar.AddEvent(activity);

            Activity[] activities = calendar.GetEventsByDate(startdatetime);

            bool finded = Array.IndexOf(activities, activity) != -1;

            Assert.IsTrue(finded, "Созданное мероприятие не найдено в календаре");
            Assert.AreEqual(name, activity.Title, "Имена не совпадают");
            Assert.AreEqual(startdatetime, activity.StartDateTime, "Время начала не совпадает");
            Assert.AreEqual(enddatetime, activity.EndDateTime, "Время окончания не совпадает");
            Assert.AreEqual(TimeZoneInfo.Local, activity.TimeZone, "Часовой пояс не совпадает");
            Assert.AreEqual("", activity.Location, "Место проведения не совпадает");
            Assert.AreEqual(false, activity.WholeDay, "Не ожидалось что мероприятие будет проходить весь день");
            Assert.AreEqual(description, activity.Description, "Описание не совпадает");
        }
    }
}

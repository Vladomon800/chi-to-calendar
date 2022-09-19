using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CalendarLib;

namespace UnitTestProject1
{
    [TestClass]
    public class DisplayingAnEventForOneDay
    {

        [TestMethod]
        public void DECOD_1()
        {

            Application app = Application.GetApplication();
            
            TimeZoneInfo timezone1 = TimeZoneInfo.GetSystemTimeZones()[4];            

            var calendars = app.GetCalendarsWithActivities();

            var calendar1 = calendars[0];           

            DateTime myDay = new DateTime(2022, 7, 5);
            
            DateTime day1 = new DateTime(2022, 7, 5);
            DateTime day2 = new DateTime(2022, 7, 31);

            Activity activity1 = new Activity() { Title = "Заголовок", StartDateTime = day1, EndDateTime = day1 };
            Activity activity2 = new Activity() { Title = "Заголовок", StartDateTime = day2, EndDateTime = day2 };

            calendar1.AddEvent(activity1);
            calendar1.AddEvent(activity2);

            Activity[] activityResult = calendar1.GetActivitisByDay(myDay);

            Assert.IsTrue(activityResult.Length != 0, "Массив с мероприятиями пустой");

            foreach (var activity in activityResult)
            {
                Assert.IsTrue(myDay.Date == activity.StartDateTime.Date, "Заданный массив не сопвадает с итоговым");
            }

        }

        [TestMethod]
        public void DECOD_2()
        {

            Application app = Application.GetApplication();
            
            TimeZoneInfo timezone2 = TimeZoneInfo.GetSystemTimeZones()[4];

            var calendars = app.GetCalendarsWithActivities();

            var calendar1 = calendars[0];           

            DateTime myDay = new DateTime(2022, 4, 5);

            DateTime day1 = new DateTime(2022, 7, 31);
            DateTime day2 = new DateTime(2022, 8, 21);

            Activity activity1 = new Activity() { Title = "Заголовок", StartDateTime = day1, EndDateTime = day1 };
            Activity activity2 = new Activity() { Title = "Заголовок", StartDateTime = day2, EndDateTime = day2 };

            calendar1.AddEvent(activity1);
            calendar1.AddEvent(activity2);

            Activity[] activityResult = calendar1.GetActivitisByDay(myDay);

            Assert.IsTrue(activityResult.Length == 0, "В итоговом массиве есть мероприятия");

        }

        [TestMethod]
        public void DECOD_3()
        {

            Application app = Application.GetApplication();

            TimeZoneInfo timezone2 = TimeZoneInfo.GetSystemTimeZones()[4];

            DateTime myDay = new DateTime(2022, 4, 5);           

            var calendars = app.GetCalendarsWithActivities();

            var calendar1 = calendars[0];

            DateTime startdatetime1 = new DateTime(2022, 4, 2);
            DateTime enddatetime1 = new DateTime(2022, 4, 11);
            DateTime startdatetime2 = new DateTime(2022, 6, 13);
            DateTime enddatetime2 = new DateTime(2022, 6, 22);

            Activity activity1 = new Activity() { Title = "Заголовок", StartDateTime = startdatetime1, EndDateTime = enddatetime1 };
            Activity activity2 = new Activity() { Title = "Заголовок", StartDateTime = startdatetime2, EndDateTime = enddatetime2 };

            calendar1.AddEvent(activity1);
            calendar1.AddEvent(activity2);

            Activity[] activityResult = calendar1.GetActivitisByDay(myDay);

            Assert.IsTrue(activityResult.Length != 0, "Массив с мероприятиями пустой");

            foreach (var activity in activityResult)
            {
                Assert.IsTrue(myDay >= activity.StartDateTime, "В массиве попались мероприятия, выходящие за начало");
                Assert.IsTrue(myDay <= activity.EndDateTime, "В массиве попались мероприятия, выходящие за конец");
            }

        }

        [TestMethod]
        public void DECOD_4()
        {
            Application app = Application.GetApplication();

            var calendars = app.GetCalendarsWithActivities();

            var calendar1 = calendars[0];

            DateTime myDay = new DateTime(2022, 11, 6);

            Activity[] activityResult = calendar1.GetActivitisByDay(myDay);

            Assert.IsTrue(activityResult.Length == 0, "Мероприятия есть");

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalendarLib;

namespace UnitTestProject1
{
    [TestClass]
    public class CreateReminder
    {
        [TestMethod]
        public void CR_1()
        {
            Application app = Application.GetApplication();

            Calendar<Reminder> calendar = app.GetCalendarWithReminders();

            string title = "Урок";
            DateTime dt = DateTime.Now;
            bool wholeDay = false;

            Reminder reminder = new Reminder() { Title = title, StartDateTime = dt, WholeDay = wholeDay };
            calendar.AddEvent(reminder);

            Reminder[] reminders = calendar.GetEventsByDate(dt);

            bool finded = Array.IndexOf(reminders, reminder) != -1;

            Assert.IsTrue(finded, "Созданное напоминание не найдено в календаре");
            Assert.AreEqual(title, reminder.Title, "Имена не совпадают");
            Assert.AreEqual(dt, reminder.StartDateTime, "Время напоминания не совпадает");
            Assert.AreEqual(wholeDay, reminder.WholeDay, "Ожидалось что напоминание будет целый день");
        }


        [TestMethod]
        public void CR_2()
        {
            Application app = Application.GetApplication();

            Calendar<Reminder> calendar = app.GetCalendarWithReminders();

            string title = "";
            DateTime dt = DateTime.Now;
            bool wholeDay = false;

            Reminder reminder = new Reminder() { Title = title, StartDateTime = dt, WholeDay = wholeDay };
            calendar.AddEvent(reminder);

            Reminder[] reminders = calendar.GetEventsByDate(dt);

            bool finded = Array.IndexOf(reminders, reminder) != -1;

            Assert.IsTrue(finded, "Созданное напоминание не найдено в календаре");
            Assert.AreEqual(title, reminder.Title, "Имена не совпадают");
            Assert.AreEqual(dt, reminder.StartDateTime, "Время напоминания не совпадает");
            Assert.AreEqual(wholeDay, reminder.WholeDay, "Ожидалось что напоминание будет целый день");
        }


        [TestMethod]
        public void CR_3()
        {
            Application app = Application.GetApplication();

            Calendar<Reminder> calendar = app.GetCalendarWithReminders();

            string title = "Годовщина";
            DateTime dt = new DateTime(2022, 4, 4, 12, 0, 0);
            bool wholeDay = false;

            Reminder reminder = new Reminder() { Title = title, StartDateTime = dt, WholeDay = wholeDay };
            calendar.AddEvent(reminder);

            Reminder[] reminders = calendar.GetEventsByDate(dt);

            bool finded = Array.IndexOf(reminders, reminder) != -1;

            Assert.IsTrue(finded, "Созданное напоминание не найдено в календаре");
            Assert.AreEqual(title, reminder.Title, "Имена не совпадают ");
            Assert.AreEqual(dt, reminder.StartDateTime, "Время напоминания не совпадает");
            Assert.AreEqual(wholeDay, reminder.WholeDay, "Ожидалось что напоминание будет целый день");
        }


        [TestMethod]
        public void CR_4()
        {
            Application app = Application.GetApplication();

            Calendar<Reminder> calendar = app.GetCalendarWithReminders();

            string title = "";
            DateTime dt = DateTime.Today;
            bool wholeDay = true;

            Reminder reminder = new Reminder() { Title = title, StartDateTime = dt, WholeDay = wholeDay };
            calendar.AddEvent(reminder);

            Reminder[] reminders = calendar.GetEventsByDate(dt);

            bool finded = Array.IndexOf(reminders, reminder) != -1;

            Assert.IsTrue(finded, "Созданное напоминание не найдено в календаре");
            Assert.AreEqual(title, reminder.Title, "Имена не совпадают");
            Assert.AreEqual(dt, reminder.StartDateTime, "Время напоминания не совпадает");
            Assert.AreEqual(wholeDay, reminder.WholeDay, "Ожидалось что напоминание будет целый день");
        }
    }
}


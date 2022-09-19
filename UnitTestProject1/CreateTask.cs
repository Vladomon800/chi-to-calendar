using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalendarLib;

namespace UnitTestProject1
{
    [TestClass]
    public class CreateTask
    {
        [TestMethod]
        public void CT_1()
        {
            Application app = Application.GetApplication();

            Calendar<Task>[] calendars = app.GetCalendarsWithTasks();
            var calendar = calendars[0];

            string name = "";
            DateTime startdatetime = new DateTime(2022, 03, 30, 10, 30, 00);
            Task task = new Task() { Title = name, StartDateTime = startdatetime };
            calendar.AddEvent(task);

            Task[] tasks = calendar.GetEventsByDate(startdatetime);

            bool finded = Array.IndexOf(tasks, task) != -1;

            Assert.IsTrue(finded, "Созданное мероприятие не найдено в календаре");
            Assert.AreEqual(name, task.Title, "Имена не совпадают");
            Assert.AreEqual(startdatetime, task.StartDateTime, "Время окончания не совпадает");
            Assert.AreEqual(false, task.WholeDay, "Не ожидалось что задача будет проходить весь день");
        }

        [TestMethod]
        public void CT_2()
        {
            Application app = Application.GetApplication();

            Calendar<Task>[] calendars = app.GetCalendarsWithTasks();
            var calendar = calendars[0];

            string name = "Тест";
            DateTime startdatetime = new DateTime(2022, 03, 30, 10, 30, 00);
            Task task = new Task() { Title = name, StartDateTime = startdatetime };
            calendar.AddEvent(task);

            Task[] tasks = calendar.GetEventsByDate(startdatetime);

            bool finded = Array.IndexOf(tasks, task) != -1;

            Assert.IsTrue(finded, "Созданное мероприятие не найдено в календаре");
            Assert.AreEqual(name, task.Title, "Имена не совпадают");
            Assert.AreEqual(startdatetime, task.StartDateTime, "Время окончания не совпадает");
            Assert.AreEqual(false, task.WholeDay, "Не ожидалось что задача будет проходить весь день");
        }

        [TestMethod]
        public void CT_3()
        {
            Application app = Application.GetApplication();

            Calendar<Task>[] calendars = app.GetCalendarsWithTasks();
            var calendar = calendars[0];

            string name = "Тест";
            DateTime startdatetime = new DateTime(2022, 03, 30, 10, 30, 00);
            Task task = new Task() { Title = name, StartDateTime = startdatetime };
            calendar.AddEvent(task);

            Task[] tasks = calendar.GetEventsByDate(startdatetime);

            bool finded = Array.IndexOf(tasks, task) != -1;

            Assert.IsTrue(finded, "Созданное мероприятие не найдено в календаре");
            Assert.AreEqual(name, task.Title, "Имена не совпадают");
            Assert.AreEqual(startdatetime, task.StartDateTime, "Время окончания не совпадает");
            Assert.AreEqual(false, task.WholeDay, "не ожидалось что задача будет проходить весь день");
        }

        [TestMethod]
        public void CT_4()
        {
            Application app = Application.GetApplication();

            Calendar<Task>[] calendars = app.GetCalendarsWithTasks();
            var calendar = calendars[0];

            string name = "Тест";
            DateTime startdatetime = new DateTime(2022, 03, 30, 10, 30, 00);
            Task task = new Task() { Title = name, StartDateTime = startdatetime };
            calendar.AddEvent(task);

            Task[] tasks = calendar.GetEventsByDate(startdatetime);

            bool finded = Array.IndexOf(tasks, task) != -1;

            Assert.IsTrue(finded, "Созданное мероприятие не найдено в календаре");
            Assert.AreEqual(name, task.Title, "Имена не совпадают");
            Assert.AreEqual(startdatetime, task.StartDateTime, "Время окончания не совпадает");
            Assert.AreEqual(false, task.WholeDay, "Не жидалось что задача будет проходить весь день");
        }

        [TestMethod]
        public void CT_5()
        {
            Application app = Application.GetApplication();

            Calendar<Task>[] calendars = app.GetCalendarsWithTasks();
            var calendar = calendars[0];

            string name = "Тест";
            DateTime startdatetime = new DateTime(2022, 03, 30, 10, 30, 00);
            string description = "Тестовая задача";
            Task task = new Task() { Title = name, Description = description, StartDateTime = startdatetime, WholeDay = true };
            calendar.AddEvent(task);

            Task[] tasks = calendar.GetEventsByDate(startdatetime);

            bool finded = Array.IndexOf(tasks, task) != -1;

            task.WholeDay = true;

            Assert.IsTrue(finded, "Созданное мероприятие не найдено в календаре");
            Assert.AreEqual(name, task.Title, "Имена не совпадают");
            Assert.AreEqual(startdatetime, task.StartDateTime, "Время окончания не совпадает");
            Assert.AreEqual(true, task.WholeDay, "Ожидалось что задача будет проходить весь день");
            Assert.AreEqual(task.Description, description, "Описание не совпадает");
        }

        [TestMethod]
        public void CT_6()
        {
            Application app = Application.GetApplication();

            Calendar<Task>[] calendars = app.GetCalendarsWithTasks();
            var calendar = calendars[0];

            string name = "Тест";
            DateTime startdatetime = new DateTime(2022, 03, 30, 10, 30, 00);
            string description = "Тестовая задача";
            Task task = new Task() { Title = name, Description = description, StartDateTime = startdatetime, WholeDay = true };
            calendar.AddEvent(task);

            Task[] tasks = calendar.GetEventsByDate(startdatetime);

            bool finded = Array.IndexOf(tasks, task) != -1;

            task.WholeDay = true;

            Assert.IsTrue(finded, "Созданное мероприятие не найдено в календаре");
            Assert.AreEqual(name, task.Title, "Имена не совпадают");
            Assert.AreEqual(startdatetime, task.StartDateTime, "Время окончания не совпадает");
            Assert.AreEqual(true, task.WholeDay, "Ожидалось что задача будет проходить весь день");
            Assert.AreEqual(task.Description, description, "Описание не совпадает");
        }
    }
}

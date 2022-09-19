using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalendarLib;

namespace UnitTestProject1
{
    [TestClass]
    public class TransitionToToday
    {
        [TestMethod]
        public void TTT_1()
        {
            Application app = Application.GetApplication();
            Settings settings = app.Settings;

            DateTime now = DateTime.Today;
            settings.CalendarView = CalendarViews.Day;

            app.GoToToday();
            
            Assert.AreEqual(settings.ChosenDate, now, "Вы не на сегоднешней дате");
        }

        [TestMethod]
        public void TTT_2()
        {
            Application app = Application.GetApplication();
            Settings settings = app.Settings;

            settings.ChosenDate = new DateTime(2022, 7, 12);
            settings.CalendarView = CalendarViews.Day;

            app.GoToToday();

            Assert.AreEqual(settings.ChosenDate, DateTime.Today, "Вы не на сегоднешней дате");
        }

        [TestMethod]
        public void TTT_3()
        {
            Application app = Application.GetApplication();
            Settings settings = app.Settings;

            settings.ChosenDate = new DateTime(2022, 7, 12);
            settings.CalendarView = CalendarViews.Week;

            app.GoToToday();

            Assert.AreEqual(settings.ChosenDate, DateTime.Today, "Вы не на сегоднешней дате");
        }

        [TestMethod]
        public void TTT_4()
        {
            Application app = Application.GetApplication();
            Settings settings = app.Settings;

            settings.ChosenDate = new DateTime(2022, 7, 12);
            settings.CalendarView = CalendarViews.Month;

            app.GoToToday();

            Assert.AreEqual(settings.ChosenDate, DateTime.Today, "Вы не на сегоднешней дате");
        }

        [TestMethod]
        public void TTT_5()
        {
            Application app = Application.GetApplication();
            Settings settings = app.Settings;

            settings.ChosenDate = new DateTime(2022, 7, 12);
            settings.CalendarView = CalendarViews.Year;

            app.GoToToday();

            Assert.AreEqual(settings.ChosenDate, DateTime.Today, "Вы не на сегоднешней дате");
        }

        [TestMethod]
        public void TTT_6()
        {
            Application app = Application.GetApplication();
            Settings settings = app.Settings;

            settings.ChosenDate = new DateTime(2022, 7, 12);
            settings.CalendarView = CalendarViews.Table;

            app.GoToToday();

            Assert.AreEqual(settings.ChosenDate, DateTime.Today, "Вы не на сегоднешней дате");
        }

        [TestMethod]
        public void TTT_7()
        {
            Application app = Application.GetApplication();
            Settings settings = app.Settings;

            settings.ChosenDate = new DateTime(2022, 7, 12);
            settings.CalendarView = CalendarViews.FourDays;

            app.GoToToday();

            Assert.AreEqual(settings.ChosenDate, DateTime.Today, "Вы не на сегоднешней дате");
        }
    }
}

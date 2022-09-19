using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendarLib;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class SwitchCalendarViews
    {
        [TestMethod]
        public void SCV_1()
        {
            Settings settings = new Settings();

            settings.CalendarView = CalendarViews.Week;

            Assert.AreEqual(settings.CalendarView, CalendarViews.Week, "Виды не поменялись!");
        }

        [TestMethod]
        public void SCV_2()
        {
            Settings settings = new Settings();

            settings.CalendarView = CalendarViews.Year;

            Assert.AreEqual(settings.CalendarView, CalendarViews.Year, "Виды не поменялись!");

            settings.ShowWeekend = true;

            Assert.AreEqual(settings.ShowWeekend, true, "Отобразились выходные.");
        }

        [TestMethod]
        public void SCV_3()
        { 
            Settings settings = new Settings();

            settings.CalendarView = CalendarViews.Table;

            Assert.AreEqual(settings.CalendarView, CalendarViews.Table, "Виды не поменялись!");

        }

        [TestMethod]
        public void SCV_4()
        {
            Settings settings = new Settings();

            settings.CalendarView = CalendarViews.FourDays;

            Assert.AreEqual(settings.CalendarView, CalendarViews.FourDays, "Виды не поменялись!");

            settings.ShowWeekend = true;

            Assert.AreEqual(settings.ShowWeekend, true, "Отобразились выходные.");
        }
    }
}
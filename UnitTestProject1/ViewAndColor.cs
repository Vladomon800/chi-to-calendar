using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendarLib;

namespace UnitTestProject1
{
    [TestClass]
    public class ViewAndColor
    {
        [TestMethod]
        public void VC_1()
        {
            Application app = Application.GetApplication();

            app.Settings.Color = Color.White;
            app.Settings.View = View.Adaptive;

            Assert.AreEqual(Color.White, app.Settings.Color, "Цвет не изменился");
            Assert.AreEqual(View.Adaptive, app.Settings.View, "Представление не изменилось");
        }

        [TestMethod]
        public void VC_2()
        {
            Application app = Application.GetApplication();

            app.Settings.Color = Color.Black;
            app.Settings.View = View.Compact;

            Assert.AreEqual(Color.Black, app.Settings.Color, "Цвет не изменился");
            Assert.AreEqual(View.Compact, app.Settings.View, "Представление не изменилось");
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BliznetsVG.Sprint2.Task5.V15.Lib;

namespace Tyuiu.BliznetsVG.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            // 1-й день (1 января) - Понедельник
            Assert.AreEqual("Понедельник", ds.FindDayName(1));

            // 2-й день - Вторник
            Assert.AreEqual("Вторник", ds.FindDayName(2));

            // 7-й день - Воскресенье
            Assert.AreEqual("Воскресенье", ds.FindDayName(7));

            // 8-й день - снова Понедельник
            Assert.AreEqual("Понедельник", ds.FindDayName(8));

            // 365-й день - Понедельник
            Assert.AreEqual("Понедельник", ds.FindDayName(365));
        }
    }
}
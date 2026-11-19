using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BliznetsVG.Sprint2.Task7.V6.Lib;

namespace Tyuiu.BliznetsVG.Sprint2.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точки ВНУТРИ области
            Assert.IsTrue(ds.CheckDotInShadedArea(1.5, 0.5));  // Внутри кольца
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 2));      // На внешней границе
            Assert.IsTrue(ds.CheckDotInShadedArea(-1, 0));     // На внутренней границе

            // Точки ВНЕ области
            Assert.IsFalse(ds.CheckDotInShadedArea(0, 0));     // Внутри "дырки" (R<1)
            Assert.IsFalse(ds.CheckDotInShadedArea(0, -1));    // В нижней полуплоскости (y<0)
            Assert.IsFalse(ds.CheckDotInShadedArea(2.5, 0));   // За пределами внешней окружности (R>2)
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BliznetsVG.Sprint2.Task4.V1.Lib;

namespace Tyuiu.BliznetsVG.Sprint2.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Проверка ветки x < y (например, x = 2, y = 5)
            // z = (2 + 3) / 5 = 1
            Assert.AreEqual(1.0, ds.Calculate(2, 5));

            // Проверка ветки else (например, x = 4, y = 1)
            // z = (4 + 1) / (4 - 2) = 5 / 2 = 2.5
            Assert.AreEqual(2.5, ds.Calculate(4, 1));
        }
    }
}
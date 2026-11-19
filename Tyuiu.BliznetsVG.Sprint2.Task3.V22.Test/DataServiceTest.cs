using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BliznecVG.Sprint2.Task3.V22.Lib;

namespace Tyuiu.BliznecV.G.Sprint2.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // 1. Проверка для x > 1 (x = 2)
            // y = 2 + ((2+3)/(2-1))^2 = 2 + 5^2 = 27
            Assert.AreEqual(27.0, ds.Calculate(2));

            // 2. Проверка для x == 0
            // (0 - cos(0) + 10) / (0 - sin(0) + 12) = (9) / (12) = 0.75
            Assert.AreEqual(0.75, ds.Calculate(0));

            // 3. Проверка для -26 < x < 2 (например, x = 1)
            // y = (3 + 2/1^2)^1 = 5
            Assert.AreEqual(5.0, ds.Calculate(1));

            // 4. Проверка для x < -26 (например, x = -30)
            // y = -30 + 10*(-30) - (1/-30) = -30 - 300 + 0.0333 = -329.9666... (округлится до -329.967)
            Assert.AreEqual(-329.967, ds.Calculate(-30));
        }
    }
}
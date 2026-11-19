using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BliznetsVG.Sprint2.Task0.V24.Lib;

namespace Tyuiu.BliznetsVG.Sprint2.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 135;
            int y = 755;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            // Ожидаемый результат: (True, True, False, False, True, True)
            bool[] wait = new bool[6] { true, true, false, false, true, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
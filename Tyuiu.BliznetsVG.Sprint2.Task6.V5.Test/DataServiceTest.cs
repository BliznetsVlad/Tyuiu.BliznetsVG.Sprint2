using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BliznetsVG.Sprint2.Task6.V5.Lib;

namespace Tyuiu.BliznetsVG.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardValue()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Валет", ds.FindCardValue(11));
            Assert.AreEqual("Дама", ds.FindCardValue(12));
            Assert.AreEqual("Король", ds.FindCardValue(13));
            Assert.AreEqual("Туз", ds.FindCardValue(14));
            Assert.AreEqual("Девятка", ds.FindCardValue(9));
            Assert.AreEqual("Шестерка", ds.FindCardValue(6));
        }
    }
}
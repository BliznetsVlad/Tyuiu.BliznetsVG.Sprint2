using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BliznecV.G.Sprint2.Task2.V16.Lib;

namespace Tyuiu.BliznecV.G.Sprint2.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точки внутри области
            Assert.IsTrue(ds.CheckDotInShadedArea(2, 3));   // Верхний левый угол перекладины
            Assert.IsTrue(ds.CheckDotInShadedArea(12, 12)); // Нижний правый угол перекладины
            Assert.IsTrue(ds.CheckDotInShadedArea(6, 9));   // Центральная вертикальная линия

            // Точки вне области
            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));  // Вне сетки
            Assert.IsFalse(ds.CheckDotInShadedArea(5, 5));  // Пустая зона внутри фигуры
            Assert.IsFalse(ds.CheckDotInShadedArea(15, 15));// Вне области (правый нижний угол)
        }
    }
}
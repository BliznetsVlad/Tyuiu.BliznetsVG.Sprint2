using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BliznecV.G.Sprint2.Task2.V16.Lib
{
    public class DataService : ISprint2Task2V16
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // Проверка границ сетки (от 1 до 15)
            if (x < 1 || x > 15 || y < 1 || y > 15)
                return false;

            // Верхняя перекладина (строки 3-4, столбцы 2-13)
            bool top = (y >= 3 && y <= 4) && (x >= 2 && x <= 13);

            // Нижняя перекладина (строки 12-13, столбцы 2-13)
            bool bottom = (y >= 12 && y <= 13) && (x >= 2 && x <= 13);

            // Левая стенка (строки 5-11, столбцы 2-3)
            bool leftWall = (y >= 5 && y <= 11) && (x >= 2 && x <= 3);

            // Правая стенка (строки 5-11, столбцы 12-13)
            bool rightWall = (y >= 5 && y <= 11) && (x >= 12 && x <= 13);

            // Центральная горизонталь (строки 6-7, столбцы 4-11)
            bool centerHoriz = (y >= 6 && y <= 7) && (x >= 4 && x <= 11);

            // Центральная вертикаль (строки 8-11, столбцы 6-7)
            // Примечание: на картинке верхняя часть центральной вертикали сливается с горизонталью, а нижняя заканчивается на 11 строке
            bool centerVert = (y >= 8 && y <= 11) && (x >= 6 && x <= 7);

            return top || bottom || leftWall || rightWall || centerHoriz || centerVert;
        }
    }
}
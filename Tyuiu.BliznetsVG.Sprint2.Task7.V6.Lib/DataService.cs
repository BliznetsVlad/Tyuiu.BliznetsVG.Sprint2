using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BliznetsVG.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Условие для области: верхняя полуплоскость (y >= 0) 
            // и расстояние между внутренним (R=1) и внешним (R=2) радиусами.

            double distanceSquared = x * x + y * y;

            if (y >= 0 && distanceSquared >= 1 && distanceSquared <= 4)
            {
                return true;
            }

            return false;
        }
    }
}
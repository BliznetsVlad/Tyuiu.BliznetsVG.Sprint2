using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BliznecVG.Sprint2.Task3.V22.Lib
{
    public class DataService : ISprint2Task3V22
    {
        public double Calculate(double x)
        {
            double y;

            // Вложенные операторы if-else строго по заданию
            if (x > 1)
            {
                y = x + Math.Pow((x + 3) / (x - 1), x);
            }
            else if (x == 0)
            {
                y = (x * x - Math.Cos(x * x) + 10) / (x * x - Math.Sin(x * x) + 12);
            }
            else if (x > -26 && x < 2)
            {
                y = Math.Pow(3 + 2 / (x * x), x);
            }
            else
            {
                y = x + 10 * x - (1.0 / x);
            }

            return Math.Round(y, 3); // Округление до 3 знаков
        }
    }
}
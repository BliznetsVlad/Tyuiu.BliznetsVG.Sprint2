using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BliznetsVG.Sprint2.Task4.V1.Lib
{
    public class DataService : ISprint2Task4V1
    {
        public double Calculate(double x, double y)
        {
            // Использование тернарного оператора строго по заданию
            double z = (x < y) ? (x + 3) / y : (x + 1) / (x - 2);

            // Округление до 3 знаков после запятой
            return Math.Round(z, 3);
        }
    }
}
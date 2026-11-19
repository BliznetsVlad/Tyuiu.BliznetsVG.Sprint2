using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BliznetsVG.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            // Проверка на корректность ввода
            if (k < 1 || k > 365)
                return "Некорректный день";

            // Вычисляем остаток от деления (k - 1) на 7
            int dayIndex = (k - 1) % 7;
            string result;

            switch (dayIndex)
            {
                case 0:
                    result = "Понедельник";
                    break;
                case 1:
                    result = "Вторник";
                    break;
                case 2:
                    result = "Среда";
                    break;
                case 3:
                    result = "Четверг";
                    break;
                case 4:
                    result = "Пятница";
                    break;
                case 5:
                    result = "Суббота";
                    break;
                case 6:
                    result = "Воскресенье";
                    break;
                default:
                    result = "Ошибка";
                    break;
            }

            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BliznetsVG.Sprint2.Task6.V5.Lib
{
    public class DataService : ISprint2Task6V5
    {
        public string FindCardValue(int value)
        {
            if (value < 6 || value > 14)
                return "Некорректный номер карты";

            switch (value)
            {
                case 11: return "Валет";
                case 12: return "Дама";
                case 13: return "Король";
                case 14: return "Туз";
                case 6: return "Шестерка";
                case 7: return "Семерка";
                case 8: return "Восьмерка";
                case 9: return "Девятка";
                case 10: return "Десятка";
                default: return "Ошибка";
            }
        }
    }
}
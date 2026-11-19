using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BliznecV.G.Sprint2.Task2.V16.Lib;

namespace Tyuiu.BliznecV.G.Sprint2.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Близнец В.Г. | ...";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if (условия)                                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Близнец В.Г.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 0, y = 0;
            bool isValidX, isValidY;

            // Ввод и проверка X
            do
            {
                Console.Write("Введите координату X (от 1 до 15): ");
                isValidX = int.TryParse(Console.ReadLine(), out x);
                if (!isValidX || x < 1 || x > 15)
                {
                    Console.WriteLine("Ошибка! Введите целое число от 1 до 15.");
                    isValidX = false;
                }
            } while (!isValidX);

            // Ввод и проверка Y
            do
            {
                Console.Write("Введите координату Y (от 1 до 15): ");
                isValidY = int.TryParse(Console.ReadLine(), out y);
                if (!isValidY || y < 1 || y > 15)
                {
                    Console.WriteLine("Ошибка! Введите целое число от 1 до 15.");
                    isValidY = false;
                }
            } while (!isValidY);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызов исправленного метода
            bool result = ds.CheckDotInShadedArea(x, y);

            if (result)
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) ПОПАДАЕТ в заштрихованную область.");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) НЕ ПОПАДАЕТ в заштрихованную область.");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
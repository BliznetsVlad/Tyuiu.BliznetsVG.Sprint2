using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BliznetsVG.Sprint2.Task0.V24.Lib
{
    public class DataService : ISprint2Task0V24
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            // x = 135, y = 755
            // 1. == (x / 5 == 27) -> 135 / 5 = 27 -> True
            res[0] = x / 5 == 27;

            // 2. != (y % 10 != 0) -> 755 % 10 = 5 -> True
            res[1] = y % 10 != 0;

            // 3. < (x < y / 100) -> 135 < 7 -> False
            res[2] = x < y / 100;

            // 4. > (x > y) -> 135 > 755 -> False
            res[3] = x > y;

            // 5. <= (x * 2 <= y - 400) -> 270 <= 355 -> True
            res[4] = x * 2 <= y - 400;

            // 6. >= (y / 5 >= x) -> 151 >= 135 -> True
            res[5] = y / 5 >= x;

            return res;
        }
    }
}
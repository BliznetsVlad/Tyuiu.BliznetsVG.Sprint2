using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BliznecV.G.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            // 1. Операция сравнения '>' и логическая '|'
            res[0] = (a > b) | (c == d);

            // 2. Операция сравнения '<' и логическая '&'
            res[1] = (a < b) & (c != d);

            // 3. Операция сравнения '<=' и логическая '||'
            res[2] = (a <= c) || (b == c);

            // 4. Операция сравнения '>=' и логическая '&&'
            res[3] = (a >= b) && (c > d);

            // 5. Операция сравнения '!=' и логическая '!'
            res[4] = !(a != b);

            // 6. Операция сравнения '<' и логическая '^'
            res[5] = (a < b) ^ (c == d);

            return res;
        }
    }
}
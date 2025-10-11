using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.LevakovaAA.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (b < a) | (c > a);
            res[1] = (b < a) & (c > a);
            res[2] = (b < a) || (c > a);
            res[3] = (b < a) && (c > a);
            res[4] = !res[1];
            res[5] = (c > a) ^ (b < d);
            return res;
        }
    }
}

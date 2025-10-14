using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.LevakovaAA.Sprint2.Task2.V25.Lib
{
    public class DataService : ISprint2Task2V25
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((((y == 5) || (y == 6)) && ((x == 1) && (x == 2))) || ((((y >= 3) && (y <= 7)) || (y == 11)) && ((x >= 3) && (x <= 5))) || (((y >= 5) && (y <= 11)) && ((x == 7) || (x == 6))) || ((x == 8) && ((y >= 5) && (y <= 8))) || ((y == 12) && ((x == 7) || (x == 10))) || (((y >= 3) && (y <= 8)) && ((x >= 9) && (x <= 12))) || ((x == 13) && ((y >= 6) && (y <= 8))) || (((y >= 9) && (y <= 11)) && ((x == 10) || (x == 11))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;

        }
    }
}

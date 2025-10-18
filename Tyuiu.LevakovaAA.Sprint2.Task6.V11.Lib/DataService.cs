using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.LevakovaAA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string x;

            switch (m)
            {

                case 1: 
                    x = "31"; break;
                case 2: x = "28"; break;
                case 3: x = "31"; break;
                case 4: x = "30"; break;
                case 5: x = "31"; break;
                case 6: x = "30"; break;
                case 7: x = "31"; break;
                case 8: x = "31"; break;
                case 9: x = "30"; break;
                case 10: x = "31"; break;
                case 11: x = "30"; break;
                case 12: x = "31"; break;
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }
            int p = Convert.ToInt32(x);
            if ((n + 1) > p)
            {
                n = 1;
                m = m + 1;
                if (m > 12)
                {
                    m = 1;
                    g = g + 1;
                }
            }
            n = n + 1;
            string nn = n.ToString().PadLeft(2, '0');
            string mm = m.ToString().PadLeft(2, '0');
            string gg = g.ToString().PadLeft(4, '0');
             string res = "Дата следующего дня: " + nn + "." + mm + "." + gg;
            return res;
        }
    }
}

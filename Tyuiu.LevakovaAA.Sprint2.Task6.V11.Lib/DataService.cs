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
            switch(m)
            {
                case 1: return "31";
                case 2: return "28";
                case 3: return "31";
                case 4: return "30";
                case 5: return "31";
                case 6: return "30";
                case 7: return "31";
                case 8: return "31";
                case 9: return "30";
                case 10: return "31";
                case 11: return "30";
                case 12: return "31";
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }
        }
    }
}

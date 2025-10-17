using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LevakovaAA.Sprint2.Task6.V11.Lib;
namespace Tyuiu.LevakovaAA.Sprint2.Task6.V11
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Левакова А.А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание 6                                                               *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Левакова А.А. | СМАРТб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m  *");
            Console.WriteLine("* определить дату следующего дня. Заданный год не является високосным.    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((m < 1) || (m > 12))
            {
                res = "Введено неверное значение";
            }
            else
            {
                int x = int.Parse(ds.FindDateOfNextDay(g, m, n));
                if ((n + 1) > x)
                {
                    n = 2;
                    m = m + 1;
                    if (m > 12)
                    {
                        m = 1;
                        g = g + 1;
                    }
                }
                else
                {
                    n = n + 2;
                }
                    string nn = n.ToString().PadLeft(2, '0');
                    string mm = m.ToString().PadLeft(2, '0');
                    string gg = g.ToString().PadLeft(2, '0');
                    res = "Дата следующего дня: " + nn + "." + mm + "." + gg;
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

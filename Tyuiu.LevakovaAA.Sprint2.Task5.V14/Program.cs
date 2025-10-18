using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LevakovaAA.Sprint2.Task5.V14.Lib;
namespace Tyuiu.LevakovaAA.Sprint2.Task5.V14
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Левакова А.А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание 5                                                               *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Левакова А.А. | СМАРТб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Дано целое число k. Определить, каким днем недели является k-й день     *");
            Console.WriteLine("* не високосного года, в котором 1 января d-й день недели.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной d: ");
            int d = Convert.ToInt32(Console.ReadLine());

            string res;

            if (k < 1 | k > 365 | d < 1 | d > 7)
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = "День недели: " + ds.FindDayName(k, d);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

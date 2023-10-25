using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DudkovIE.Sprint3.Task5.V4.Lib;
namespace Tyuiu.DudkovIE.Sprint3.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Дудков И.Е | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенный цикл                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                             *");
            Console.WriteLine("* Выполнил: Дудков И.Е  | СМАРТб-23-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти сумму ряда вложенного цикла при входных данных(5, 1, 3, 1, 13)*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x, startvalue1, endvalue1, startvalue2, endvalue2 :");
            int x = int.Parse(Console.ReadLine());
            int startValue = int.Parse(Console.ReadLine());
            int endValue = int.Parse(Console.ReadLine());
            int startValue2 = int.Parse(Console.ReadLine());
            int endValue2 = int.Parse(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.GetSumSumSeries(x, startValue, endValue, startValue2, endValue2);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DudkovIE.Sprint3.Task2.V21.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            int i = 1;
            double res = 0;
            do
            {
                res += Math.Pow(1 / (Math.Sin(i) + 2 * Math.Pow(value, i)), i);
                i++;
            } while (i <= 10);

            return Math.Round(res, 3);
        }
    }
}

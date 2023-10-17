using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DudkovIE.Sprint3.Task1.V13.Lib
{
    public class DataService : ISprint3Task1V13
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            int i = 1;
            while(i <= 7)
            {
                res = Math.Pow(1 / Math.Pow(1.2, i), -1);
                i++;
            }
            return Math.Round(res, 3);
        }
    }
}

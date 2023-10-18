using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DudkovIE.Sprint3.Task0.V14.Lib
{
    public class DataService : ISprint3Task0V14
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            for(int i = startValue; i <= stopValue; i++)
            {
                res += Math.Pow(1 / Math.Pow(i, 2), -1);
            }
            return Math.Round(res, 3);
        }
    }
}

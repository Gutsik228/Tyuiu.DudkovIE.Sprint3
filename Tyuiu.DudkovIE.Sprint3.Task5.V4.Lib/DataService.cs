using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DudkovIE.Sprint3.Task5.V4.Lib
{
    public class DataService : ISprint3Task5V4
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for(int i = startValue1; i <= stopValue1; i++)
            {
                for(int j = startValue2; j <= stopValue2; j++)
                {
                    res += x / (Math.Cos(j));
                }
            }
            return Math.Round(res, 3);
        }
    }
}

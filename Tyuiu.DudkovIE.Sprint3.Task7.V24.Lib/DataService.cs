using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DudkovIE.Sprint3.Task7.V24.Lib
{
    public class DataService : ISprint3Task7V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];

            int i = 0;
            double y;
            for(int x = startValue; x <= stopValue; x++)
            {
                y = (Math.Sin(x)) / (x + 1.2) - (Math.Sin(x) * 2) - (2 * x);
                res[i] = Math.Round(y, 2, MidpointRounding.AwayFromZero);
                i++;
            }
            return res;

        }
    }
}

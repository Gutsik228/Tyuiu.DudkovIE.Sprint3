using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DudkovIE.Sprint3.Task4.V6.Lib
{
    public class DataService : ISprint3Task4V6
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y += x / (Math.Cos(x) - Math.Sin(x)); 
                if(x == 0)
                {
                    break;
                }
            }

            return Math.Round(y, 3);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DudkovIE.Sprint3.Task6.V28.Lib
{
    public class DataService : ISprint3Task6V28
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for(int i = startValue; i <= stopValue; i++)
            {
                for(int j = 1; j < 7; j++)
                {
                    if(i % j == 0)
                    {
                        count += 1;
                    }
                }

            }

            return count;
        }
    }
}

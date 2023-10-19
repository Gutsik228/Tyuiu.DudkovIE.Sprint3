using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DudkovIE.Sprint3.V7.Lib
{
    public class DataService : ISprint3Task3V7
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string res = value;
            foreach(char c in res)
            {
                if(c == 'g')
                {
                    res = res.Replace(c, '4');
                }
            }
            return res;
        }
    }
}

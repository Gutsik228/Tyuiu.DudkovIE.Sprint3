using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint3.Task7.V24.Lib;
namespace Tyuiu.DudkovIE.Sprint3.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5, stopValue = 5;
            double[] wait = new double[stopValue - startValue + 1];
            wait[0] = 7.83;
            wait[1] = 6.22;
            wait[2] = 6.36;
            wait[3] = 6.96;
            wait[4] = -0.52;
            wait[5] = 0;
            wait[6] = -3.30;
            wait[7] = -5.53;
            wait[8] = -6.25;
            wait[9] = -6.63;
            wait[10] = -8.24;

            var res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}

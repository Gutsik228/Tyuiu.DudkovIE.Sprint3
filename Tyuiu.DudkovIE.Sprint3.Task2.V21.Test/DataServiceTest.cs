using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint3.Task2.V21.Lib;
namespace Tyuiu.DudkovIE.Sprint3.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.GetSumSeries(1.5, 1, 10);

            Assert.AreEqual(0.298, res);
        }
    }
}

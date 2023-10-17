using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint3.Task0.V14.Lib;
namespace Tyuiu.DudkovIE.Sprint3.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.GetSumSeries(1, 1, 5);

            Assert.AreEqual(25, res);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint3.Task1.V13.Lib;
namespace Tyuiu.DudkovIE.Sprint3.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(1, 1, 7);
            Assert.AreEqual(3.583, res);
        }
    }
}

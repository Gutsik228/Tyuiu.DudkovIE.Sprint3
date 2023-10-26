using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint3.Task6.V28.Lib;
namespace Tyuiu.DudkovIE.Sprint3.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(13, 19);
            Assert.AreEqual(15, result);
        }
    }
}

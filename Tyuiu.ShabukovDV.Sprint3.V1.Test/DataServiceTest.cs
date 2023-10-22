using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabukovDV.Sprint3.V1.Lib;

namespace Tyuiu.ShabukovDV.Sprint3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(1935, service1.GetSumSeries(4, 1, 15));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint1.Task5.V6.Lib;

namespace Tyuiu.PomazDS.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int n = 6;
            int k = 13;
            var res = ds.Calculate(k);
            Assert.AreEqual(n, res);
        }
    }
}

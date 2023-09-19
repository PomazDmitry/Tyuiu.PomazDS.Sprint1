using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint1.Task1.V27.Lib;

namespace Tyuiu.PomazDS.Sprint1.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 2.0;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(2.5, res);
        }
    }
}

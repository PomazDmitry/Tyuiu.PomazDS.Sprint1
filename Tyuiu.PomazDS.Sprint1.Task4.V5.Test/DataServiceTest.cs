using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint1.Task4.V5.Lib;

namespace Tyuiu.PomazDS.Sprint1.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x, y;
            x = 25;
            y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.038, res);
            
        }
    }
}

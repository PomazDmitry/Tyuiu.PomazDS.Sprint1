using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint1.Task7.V13.Lib;

namespace Tyuiu.PomazDS.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            var res = ds.Calculate(x, y);

            Assert.AreEqual(0.978, res);
        }
    }
}

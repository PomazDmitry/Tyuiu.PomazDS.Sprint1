using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint1.Task3.V1.Lib;

namespace Tyuiu.PomazDS.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 2;
            double h = 4;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(50.265, res);
        }
    }
}

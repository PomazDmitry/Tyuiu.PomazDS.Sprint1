using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint1.Task2.V14.Lib;

namespace Tyuiu.PomazDS.Sprint1.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 274;
            var res = ds.ConvertKelvinToCelsius(value);
            Assert.AreEqual(1, res);  
        }
    }
}

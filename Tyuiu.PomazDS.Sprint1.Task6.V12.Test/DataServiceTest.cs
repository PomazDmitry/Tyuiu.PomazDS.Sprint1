using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint1.Task6.V12.Lib;

namespace Tyuiu.PomazDS.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string text = "This text has last repeat word. Repeat word is text";

            var res = ds.CheckLastWordRepetiton(text);

            Assert.AreEqual(true, res);
        }
    }
}

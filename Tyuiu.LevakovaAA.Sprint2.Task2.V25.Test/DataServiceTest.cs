using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint2.Task2.V25.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint2.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}

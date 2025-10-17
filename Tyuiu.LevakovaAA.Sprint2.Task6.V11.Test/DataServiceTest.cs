using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint2.Task6.V11.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 1;
            int n = 1;
            Assert.AreEqual("31", ds.FindDateOfNextDay(g, 1, n));
            Assert.AreEqual("28", ds.FindDateOfNextDay(g, 2, n));
            Assert.AreEqual("31", ds.FindDateOfNextDay(g, 3, n));
            Assert.AreEqual("30", ds.FindDateOfNextDay(g, 4, n));
            Assert.AreEqual("31", ds.FindDateOfNextDay(g, 5, n));
            Assert.AreEqual("30", ds.FindDateOfNextDay(g, 6, n));
            Assert.AreEqual("31", ds.FindDateOfNextDay(g, 7, n));
            Assert.AreEqual("31", ds.FindDateOfNextDay(g, 8, n));
            Assert.AreEqual("30", ds.FindDateOfNextDay(g, 9, n));
            Assert.AreEqual("31", ds.FindDateOfNextDay(g, 10, n));
            Assert.AreEqual("30", ds.FindDateOfNextDay(g, 11, n));
            Assert.AreEqual("31", ds.FindDateOfNextDay(g, 12, n));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(g, -1, n);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(g, 13, n);
            });
        }
    }
}

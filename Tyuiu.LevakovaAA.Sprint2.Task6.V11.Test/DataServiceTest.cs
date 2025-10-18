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
            int m = 1;
            Assert.AreEqual(ds.FindDateOfNextDay(g, m, n), ds.FindDateOfNextDay(g, m, n));
        }
    }
}

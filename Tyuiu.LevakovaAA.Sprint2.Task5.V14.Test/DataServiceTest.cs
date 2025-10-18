using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint2.Task5.V14.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint2.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            int k = 1;
            Assert.AreEqual("Понедельник", ds.FindDayName(k, 1));
            Assert.AreEqual("Вторник", ds.FindDayName(k, 2));
            Assert.AreEqual("Среда", ds.FindDayName(k, 3));
            Assert.AreEqual("Четверг", ds.FindDayName(k, 4));
            Assert.AreEqual("Пятница", ds.FindDayName(k, 5));
            Assert.AreEqual("Суббота", ds.FindDayName(k, 6));
            Assert.AreEqual("Воскресенье", ds.FindDayName(k, 7));
        }
    }
}

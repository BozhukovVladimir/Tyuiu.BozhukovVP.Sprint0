using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BozhukovVP.Sprint0.Task2.V0.Lib;
namespace Tyuiu.BozhukovVP.Sprint0.Taskk2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Владимир";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Владимир", res);
        }
    }
}

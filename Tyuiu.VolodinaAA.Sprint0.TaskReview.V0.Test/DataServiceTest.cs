using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.VolodinaAA.Sprint0.TaskReview.V0.Test
{  
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(30, DataService.Calc(1, 2, 3));
        }
    }
}

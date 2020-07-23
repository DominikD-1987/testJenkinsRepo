using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsFirstTry;

namespace JenkinsFirstTry
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() {
            double x = 4;
            double y = 5;

            double expectedVal = 9;


            Assert.AreEqual(expectedVal, BasicOps.Sum(x, y));

        }
    }
}

using System;
using tjmodul12_2311104076;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Negatif()
        {
            var result = BilanganHelper.CariTandaBilangan(-5);
            Assert.AreEqual("Negatif", result);
        }

        [TestMethod]
        public void Test_Positif()
        {
            var result = BilanganHelper.CariTandaBilangan(7);
            Assert.AreEqual("Positif", result);
        }

        [TestMethod]
        public void Test_Nol()
        {
            var result = BilanganHelper.CariTandaBilangan(0);
            Assert.AreEqual("Nol", result);
        }
    }
}
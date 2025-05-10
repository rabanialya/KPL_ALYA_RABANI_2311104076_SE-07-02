using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpmodul12_2311104076;

namespace UnitTest
{
    [TestClass]
    public class BilanganHelperTests
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
            var result = BilanganHelper.CariTandaBilangan(10);
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

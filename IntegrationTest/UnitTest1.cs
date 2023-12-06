using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTest
{
    [TestClass]
    [Obsolete()]
    public class UnitTest1
    {
        [TestMethod]
        public void CaseSort()
        {
            Assert.AreEqual("Boom boom", SimpleTest.MyTest.CalculateTotal("boom Boom"));
        }

        [TestMethod]
        public void RemoveInvalidChars()
        {
            Assert.AreEqual("b b", SimpleTest.MyTest.CalculateTotal("b, b"));
        }

        [TestMethod]
        public void SimpleTest1()
        {
            Assert.AreEqual("baby Go go", SimpleTest.MyTest.CalculateTotal("Go baby, go"));
        }

        [TestMethod]
        public void SimpleTest2()
        {
            Assert.AreEqual("ABC aBc abc CBA CBA cba", SimpleTest.MyTest.CalculateTotal("CBA, abc aBc ABC cba CBA."));
        }

        [TestMethod]
        public void WordSort()
        {
            Assert.AreEqual("Boom Zoom", SimpleTest.MyTest.CalculateTotal("Zoom Boom"));
        }
    }
}
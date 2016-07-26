using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taschenrechner;

namespace UnitTestProject1
{
    [TestClass]
    public class TaschenrechnerTests
    {
        [TestMethod]
        public void BerechnerTest()
        {
            var failedCalled = false;
            var backend = new TaschenrechnerBackend();
            backend.Berechne('6', s => Assert.AreEqual("6", s), s => Assert.Fail());
            backend.Berechne('4', s => Assert.AreEqual("64", s), s => Assert.Fail());
            backend.Berechne('%', s => Assert.AreEqual("64", s), s => Assert.Fail());
            backend.Berechne('0', s => Assert.AreEqual("0", s), s => Assert.Fail());
            backend.Berechne('=', s => Assert.AreEqual("64", s), s =>
            {
                failedCalled = true;
                Assert.AreEqual("Division durch 0", s);
            });
            Assert.IsTrue(failedCalled,"Kein Fehler aufgerufen");
            backend.Berechne('8', s => Assert.AreEqual("8", s), s => Assert.Fail());
            backend.Berechne('=', s => Assert.AreEqual("8", s), s => Assert.Fail());
        }

        [TestMethod]
        public void ZerlegenTest()
        {
            var backend = new TaschenrechnerBackend();
            var zifferErkannt = false;
            var operatorErkannt = false;
            backend.Zerlegen('1', c => zifferErkannt= true, c=> operatorErkannt = true);
            Assert.IsTrue(zifferErkannt);
            Assert.IsFalse(operatorErkannt);

            zifferErkannt = false;
            operatorErkannt = false;
            backend.Zerlegen('+', c => zifferErkannt = true, c => operatorErkannt = true);
            Assert.IsFalse(zifferErkannt);
            Assert.IsTrue(operatorErkannt);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorteZählen;

namespace WorteZählenTest
{
    [TestClass]
    public class AcceptanceTest
    {
        [TestMethod]
        public void Test_zähle_Wörter()
        {
            string[] stopwörter = {"the", "a", "on", "off", "Malte", "Welt", "Ralph"};

            Assert.AreEqual(1, WortZähler.Zähle_Wörter("Hallo Welt", stopwörter));
            Assert.AreEqual(1, WortZähler.Zähle_Wörter("Hallo Welt 99", stopwörter));
            Assert.AreEqual(2, WortZähler.Zähle_Wörter("Hallo Welt 9th Street", stopwörter));
            Assert.AreEqual(1, WortZähler.Zähle_Wörter("Good n8", stopwörter));
            Assert.AreEqual(1, WortZähler.Zähle_Wörter("Hello \"Malte\"", stopwörter));
            Assert.AreEqual(2, WortZähler.Zähle_Wörter("Moin  Ralf ", stopwörter));
            Assert.AreEqual(3, WortZähler.Zähle_Wörter("Nu is daddeldu!", stopwörter));
            Assert.AreEqual(1, WortZähler.Zähle_Wörter("a.b", stopwörter));
            Assert.AreEqual(1, WortZähler.Zähle_Wörter("A.B", stopwörter));
            Assert.AreEqual(2, WortZähler.Zähle_Wörter("Hallo a Welt for Malte", stopwörter));
        }
    }
}
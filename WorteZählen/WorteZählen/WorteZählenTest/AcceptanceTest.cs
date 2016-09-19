using System.Reflection.Emit;
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

            Assert.AreEqual(1, WortZähler.Zähle_Wörter("Hallo Welt", stopwörter).Anzahl_Wörter);
            Assert.AreEqual(1, WortZähler.Zähle_Wörter("Hallo Welt 99", stopwörter).Anzahl_Wörter);
            Assert.AreEqual(2, WortZähler.Zähle_Wörter("Hallo Welt 9th Street", stopwörter).Anzahl_Wörter);
            Assert.AreEqual(1, WortZähler.Zähle_Wörter("Good n8", stopwörter).Anzahl_Wörter);
            Assert.AreEqual(1, WortZähler.Zähle_Wörter("Hello \"Malte\"", stopwörter).Anzahl_Wörter);
            Assert.AreEqual(2, WortZähler.Zähle_Wörter("Moin  Ralf ", stopwörter).Anzahl_Wörter);
            Assert.AreEqual(3, WortZähler.Zähle_Wörter("Nu is daddeldu!", stopwörter).Anzahl_Wörter);
            Assert.AreEqual(1, WortZähler.Zähle_Wörter("a.b", stopwörter).Anzahl_Wörter);
            Assert.AreEqual(1, WortZähler.Zähle_Wörter("A.B", stopwörter).Anzahl_Wörter);
            Assert.AreEqual(2, WortZähler.Zähle_Wörter("Hallo a Welt for Malte", stopwörter).Anzahl_Wörter);
        }

        [TestMethod]
        public void Test_zähle_eindeutige_Wörter()
        {
            string[] stopwörter = {"the", "a", "on", "off", "Malte", "Welt", "Ralph"};
            string text = "Humpty-Dumpty sat on a wall. Humpty-Dumpty had a great fall.";

            var ergebnis = WortZähler.Zähle_Wörter(text, stopwörter);
            Assert.AreEqual(7, ergebnis.Anzahl_Wörter);
            Assert.AreEqual(6, ergebnis.Anzahl_eindeutiger_Wörter);

        }
    }
}
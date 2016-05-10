using System;
using System.Linq;
using System.Text;
using BankOCR;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankOCRTest
{
    [TestClass]
    public class BankOCRTest
    {
        [TestMethod]
        public void AcceptanceTest()
        {
            string[] expected = {"14", "0"};
            var digits = FileReader.ReadAllLines("Datei1.txt");
            CollectionAssert.AreEqual(expected, OCR.RecognizeDigits(digits));
        }
    }
}

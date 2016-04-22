using System;
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
            CollectionAssert.AreEqual(expected, BankOCRTool.RecognizeDigitsInFile("Datei1.txt"));
        }
    }
}

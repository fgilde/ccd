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
            CollectionAssert.AreEqual(expected, BankOCRTool.RecognizeDigitsInFile("Datei1.txt"));
        }

        [TestMethod]
        public void ParsePacketsTest()
        {
            var input = new string[][] { new [] {"   ","  I","  I"} };
            CollectionAssert.AreEqual(new [] {"1"}, BankOCRTool.ParsePackets(input).ToArray());
        }

        [TestMethod]
        public void MapToRowTest()
        {
            var source = new string[] {" _ I II_I" /*0*/, "     I  I" /*1*/, " _   I  I" /*7*/, " _  _II_ " /*2*/};
            Assert.AreEqual("0172", BankOCRTool.MapToRow(source));
        }

        [TestMethod]
        public void FlattenOCRDigitsTest()
        {
            var source = new string[] {
                " _       _   _ ",
                "I I   I   I  _I" ,
                "I_I   I   I I_ " };

            var expected = new string[] { " _ I II_I" /*0*/, "     I  I" /*1*/, " _   I  I" /*7*/, " _  _II_ " /*2*/};
            CollectionAssert.AreEqual(expected,BankOCRTool.FlattenOCRDigits(source).ToArray());
        }

        [TestMethod]
        public void SplitIntoPacketsTest()
        {
            var input = new string[] {
                "       ",
                "  I I_I",
                "  I   I",
                "",
                " _ ",
                "I I",
                "I_I" };

            var expected =
                new string[][]
                {
                    new string[]
                    {
                        "       ",
                        "  I I_I",
                        "  I   I"
                    },
                    new string[]
                    {
                        " _ ",
                        "I I",
                        "I_I"
                    }
                };

            var result = BankOCRTool.SplitIntoPackets(input);

            CollectionAssert.AreEqual(expected[0], result[0]);
            CollectionAssert.AreEqual(expected[1], result[1]);
        }

    }
}

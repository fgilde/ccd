using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSVTabelliererTest
{
    [TestClass]
    public class CSVTabelliererTest
    {
        [TestMethod]
        public void AcceptanceTest()
        {
            var zeilen = new[] {"123;ABCD;01A", "ABC;HALLO;1"};
            var erwartet = new[] {"123|ABCD |01A|", "---+-----+---+", "ABC|HALLO|1  |"};
            CollectionAssert.AreEqual(erwartet, CSVTabellierer.CSVTabellierer.Tabelliere(zeilen).ToArray());
        }

        [TestMethod]
        public void TestZerlegeInSpalten()
        {
            var zeilen = new[] { "123;ABCD;01A", "ABC;HALLO;1" };
            var zerlegeInSpalten = CSVTabellierer.CSVTabellierer.ZerlegeInSpalten(zeilen);

            Assert.AreEqual(2, zerlegeInSpalten.Count());
            Assert.IsTrue(zerlegeInSpalten.All(x=>x.Length == 3));
            CollectionAssert.AreEqual(new[] { "123","ABCD","01A"}, zerlegeInSpalten.First());
            CollectionAssert.AreEqual(new[] { "ABC", "HALLO", "1" }, zerlegeInSpalten.Last());
        }
    }
}

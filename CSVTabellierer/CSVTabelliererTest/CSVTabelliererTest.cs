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

        [TestMethod]
        public void MaxSpaltenlängenTest()
        {
            var tabelle = new[] {new[] {"123", "ABCD", "01A"}, new[] {"ABC", "HALLO", "1"}};
            var erwartet = new[] {3, 5, 3};
            CollectionAssert.AreEqual(erwartet, CSVTabellierer.CSVTabellierer.MaxSpaltenlängen(tabelle));
        }

        [TestMethod]
        public void ErmittleMaxSpaltenLängeTest()
        {
            var tabelle = new[] { new[] { "123", "ABCD", "01A" }, new[] { "ABC", "HALLO", "1" } };
            var erwartet = new[] { 3, 5, 3 };
            CollectionAssert.AreEqual(erwartet, CSVTabellierer.CSVTabellierer.ErmittleMaxSpaltenLänge(tabelle, 3));
        }


        [TestMethod]
        public void ErmittleAnzahlSpaltenTest()
        {
            var tabelle = new[] { new[] { "123", "ABCD", "01A" }, new[] { "ABC", "HALLO", "1" } };

            Assert.AreEqual(3, CSVTabellierer.CSVTabellierer.ErmittleAnzahlSpalten(tabelle));
        }
    }
}

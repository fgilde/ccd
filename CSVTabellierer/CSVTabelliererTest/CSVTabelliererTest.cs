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
        public void KonvertiereZuZeilenTest()
        {
            IEnumerable<string> result = CSVTabellierer.CSVTabellierer.KonvertiereZuZeilen(new[] {new[] {"a", "b", "c"}, new[] {"x", "y", "z"}});
            CollectionAssert.AreEqual(new [] {"abc", "xyz"}, result.ToArray());
        }

        [TestMethod]
        public void GeneriereHeadTrennerTest()
        {
            var headZeile = CSVTabellierer.CSVTabellierer.GeneriereHeadTrenner(new int[] {2, 3, 4});
            Assert.AreEqual("--+---+----+",headZeile);
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

        [TestMethod]
        public void GeneriereOutputTest()
        {
            var tabelle = new[] { new[] { "123", "ABCD", "01A" }, new[] { "ABC", "HALLO", "1" } };
            var spaltenLaenge = new[] { 3, 5, 3 };
            var erwartet = new[] { "123|ABCD |01A|", "---+-----+---+", "ABC|HALLO|1  |" };
            CollectionAssert.AreEqual(erwartet, CSVTabellierer.CSVTabellierer.GeneriereOutput(tabelle, spaltenLaenge).ToArray());
        }

        [TestMethod]
        public void NormiereTabelleMitSpaltenTrennerTest()
        {
            var tabelle = new[] { new[] { "123", "ABCD", "01A" }, new[] { "ABC", "HALLO", "1" } };
            var spaltenLaenge = new[] { 3, 5, 3 };
            var normierteTabelle = CSVTabellierer.CSVTabellierer.NormiereTabelleMitSpaltenTrenner(tabelle, spaltenLaenge);
            var erwartet = new[] { new[] { "123|", "ABCD |", "01A|" }, new[] { "ABC|", "HALLO|", "1  |" } };
            CollectionAssert.AreEqual(erwartet.First(), normierteTabelle.First());
            CollectionAssert.AreEqual(erwartet.Last(), normierteTabelle.Last());
        }


    }
}

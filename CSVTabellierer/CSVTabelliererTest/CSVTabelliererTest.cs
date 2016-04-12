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
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DublettenFinder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DublettenFinderTestProject
{
    [TestClass]
    public class DublettenFinderTests
    {
        private static string path = Path.Combine(Environment.CurrentDirectory, "TestDir");

        [TestMethod]
        public void AcceptanceTestSammle_KandidatenGrößeName()
        {
            var dublettenPrüfung = new DublettenPrüfung();
            IEnumerable<IDublette> kandidaten = dublettenPrüfung.Sammle_Kandidaten(path);

            Assert.AreEqual(1, kandidaten.Count());
            var dublette = kandidaten.First();
            Assert.AreEqual(2, dublette.Dateipfade.Count()); 
            Assert.IsTrue(dublette.Dateipfade.Any(d => d.Contains("TestDir\\File1.txt"))); 
            Assert.IsTrue(dublette.Dateipfade.Any(d => d.Contains("TestDir\\SubDir\\File1.txt"))); 
        }

        [TestMethod]
        public void AcceptanceTestSammle_KandidatenGröße()
        {
            var dublettenPrüfung = new DublettenPrüfung();
            IEnumerable<IDublette> kandidaten = dublettenPrüfung.Sammle_Kandidaten(path, Vergleichsmodi.Größe);

            Assert.AreEqual(1, kandidaten.Count());
            var dublette = kandidaten.First();
            Assert.AreEqual(3, dublette.Dateipfade.Count());
            Assert.IsTrue(dublette.Dateipfade.Any(d => d.Contains("TestDir\\File1.txt")));
            Assert.IsTrue(dublette.Dateipfade.Any(d => d.Contains("TestDir\\SubDir\\File1.txt")));
            Assert.IsTrue(dublette.Dateipfade.Any(d => d.Contains("TestDir\\File1Nochmal.txt")));
        }

        [TestMethod]
        public void AcceptanceTestPrüfe_Kandidaten()
        {
            var dublettenPrüfung = new DublettenPrüfung();
            IEnumerable<IDublette> kandidaten = new IDublette[] {new Dublette {Dateipfade = new [] { path +"\\File1.txt", path + "\\SubDir\\File1.txt", path + "\\File2.txt" }} };

            var dubletten = dublettenPrüfung.Prüfe_Kandidaten(kandidaten);
            Assert.AreEqual(1, dubletten.Count());
            IDublette dublette = dubletten.First();
            Assert.AreEqual(2, dublette.Dateipfade.Count());
            Assert.IsTrue(dublette.Dateipfade.Any(d => d.Contains("TestDir\\File1.txt")));
            Assert.IsTrue(dublette.Dateipfade.Any(d => d.Contains("TestDir\\SubDir\\File1.txt")));
        }

        [TestMethod]
        public void TestGruppiereNachHash()
        {
            var dublettenPrüfung = new DublettenPrüfung();
            var kandidaten = new HashDublette[] { new HashDublette { Dateien = new[] { new Datei(new FileInfo(path + "\\File1.txt")), new Datei(new FileInfo(path + "\\SubDir\\File1.txt")), new Datei(new FileInfo(path + "\\File2.txt")) } } };

            var gruppierteDubletten = dublettenPrüfung.GruppiereNachHash(kandidaten);
            Assert.AreEqual(2, gruppierteDubletten.Count());
            IDublette dublette = gruppierteDubletten.First(d => d.Dateipfade.Count() == 2);
            Assert.IsTrue(dublette.Dateipfade.Any(d => d.Contains("TestDir\\File1.txt")));
            Assert.IsTrue(dublette.Dateipfade.Any(d => d.Contains("TestDir\\SubDir\\File1.txt")));
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCD_LocCount;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CCD_LocCountTest
{
    [TestClass]
    public class LocCountTest
    {
        [TestMethod]
        public void AcceptanceTestLocCount()
        {
            var folder = Path.Combine(Environment.CurrentDirectory, "TestData");

            List<string> result = new List<string>();

            Program.LocCount(folder, result.Add);
            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result.Contains(Path.Combine(folder, "TestFile1.cs")+ ";7;11"));
            Assert.IsTrue(result.Contains(Path.Combine(folder, "TestFile3.cs")+ ";2;8"));
            Assert.IsTrue(result.Contains(Path.Combine(folder, "SubFolder\\TestFile2.cs")+ ";3;8"));
        }

        [TestMethod]
        public void FormatLinetest()
        {
            Assert.AreEqual("TestText;123;456", Program.FormatLine("TestText", 123, 456));
        }

        [TestMethod]
        public void CountLOFTest()
        {
            Assert.AreEqual(5, Program.CountLof("a=5;\nb=1;\nc=7;\nd=9;\ne=88;"));
        }

        [TestMethod]
        public void TestFileContent()
        {
            Assert.AreEqual("hallo", Program.ReadFileContent(Path.Combine(Environment.CurrentDirectory, "TestData", "FileToIgnore.log")));
        }

        [TestMethod]
        public void GetCsFilePathsTest()
        {
            Assert.AreEqual(3, Program.GetCsFilePaths(Path.Combine(Environment.CurrentDirectory, "TestData") ).Length);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using CCD_LocCount;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CCD_LocCountTest
{
    [TestClass]
    public class LocTests
    { 
        [TestMethod]
        public void AcceptanceTestLocCountLinq()
        {
            var folder = Path.Combine(Environment.CurrentDirectory, "TestData");
            var result = new List<string>();

            LocCounter.LocCountLinq(folder, result.Add);

            Assert.Fail(); // TODO: Testen
        }

        [TestMethod]
        public void AcceptanceTestLocCount()
        {
            var folder = @"D:\!tmp\CCDLocCountTestDir";
            var result = new List<string>();

            LocCounter.LocCount(folder, result.Add);

            Assert.Fail(); // TODO: Testen
        }

        [TestMethod]
        public void AcceptanceTestLOC()
        {
            Assert.AreEqual(7, LocCounter.LOC("/// summary \n /// ...\n/// <...>\npublic void Test()\n        {\n	/* ... */\n	.\n	.\n	.\n	/* ... */ return a;\n\n        }"));
            Assert.AreEqual(3, LocCounter.LOC("var a = 5;\n/*\n.\n.\n.\n*/\na = 6; /* FOO */\na = 7; // BAR;"));
            Assert.AreEqual(2, LocCounter.LOC("Test /*\n34534\ntrzrtz */ e5zt"));
        }
        
        [TestMethod]
        public void TestDecomposeInLines()
        {
            Assert.AreEqual(8, LocCounter.DecomposeInLines("var a = 5;\n/*\n.\n.\n.\n*/\na = 6; /* FOO */\na = 7; // BAR;").Length);
        }

        [TestMethod]
        public void TestDeleteAllComments()
        {
            var source = "//Anton\nHallo\n/*Muh\nKuh\n*/";
            var expected = "\r\n\nHallo\n\r\n";
            var actual = LocCounter.DeleteComments(source);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteEmptyLines()
        {
            Assert.AreEqual(3, LocCounter.DeleteEmptyLines(new[]
            {
                string.Empty,
                "123",
                "   ",
                "456",
                "789",
                ""
            }).Length);
        }
    }
}

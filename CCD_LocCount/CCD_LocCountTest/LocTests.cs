using System;
using CCD_LocCount;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CCD_LocCountTest
{
    [TestClass]
    public class LocTests
    {
        [TestMethod]
        public void LoC_AcceptanceTest()
        {
            Assert.AreEqual(7, LocCounter.LOC("/// summary \n /// ...\n/// <...>\npublic void Test()\n        {\n	/* ... */\n	.\n	.\n	.\n	/* ... */ return a;\n\n        }"));
            Assert.AreEqual(3, LocCounter.LOC("var a = 5;\n/*\n.\n.\n.\n*/\na = 6; /* FOO */\na = 7; // BAR;"));
            Assert.AreEqual(2, LocCounter.LOC("Test /*\n34534\ntrzrtz */ e5zt"));
        }
        

        [TestMethod]
        public void TestZerlegeZeilen()
        {
            Assert.AreEqual(8, LocCounter.ZerlegeInZeilen("var a = 5;\n/*\n.\n.\n.\n*/\na = 6; /* FOO */\na = 7; // BAR;").Length);
        }

        [TestMethod]
        public void TestLöscheAlleKommentare()
        {
            var source = "//Anton\nHallo\n/*Muh\nKuh\n*/";

            var expected = "\r\n\nHallo\n\r\n";
            var löscheAlleKommentare = LocCounter.DeleteAllComments(source);
            Assert.AreEqual(expected, löscheAlleKommentare);
        }

        [TestMethod]
        public void TestLöscheAlleLeerzeilen()
        {
            Assert.AreEqual(3, LocCounter.LöscheAlleLeerzeilen(new[]
            {
                "",
                "123",
                "   ",
                "456",
                "789",
                ""
            }).Length);
        }

       

    }
}

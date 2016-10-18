using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questionnaire;

namespace Tests
{
    [TestClass]
    public class FragebogenTest
    {
        [TestMethod]
        public void TestFragebogen()
        {
            var fragebogen = new Fragebogen();
            var fragen = fragebogen.Lese_Fragebogen();

            Assert.AreEqual(3, fragen.Length);
            Assert.AreEqual("Which of these animals is a mammal", fragen[0].Text);
            Assert.AreEqual(3, fragen[0].Antworten.Length);
            Assert.AreEqual("Ant", fragen[0].Antworten[0].Text);
            Assert.IsFalse(fragen[0].Antworten[0].Richtig);
            Assert.AreEqual("Bee", fragen[0].Antworten[1].Text);
            Assert.IsFalse(fragen[0].Antworten[1].Richtig);
            Assert.AreEqual("Cat", fragen[0].Antworten[2].Text);
            Assert.IsTrue(fragen[0].Antworten[2].Richtig);
        }
    }
}

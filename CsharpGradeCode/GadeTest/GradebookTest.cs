using System;
using consoleprogram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GadeTest
{
    [TestClass]
    public class GradebookTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Gradeclass g = new Gradeclass();
            g.Addgrades(99);
            g.Addgrades(13);

            Gradestatistics d = g.computestats();


            Assert.AreEqual(99, d.Higheststats);
        }
    }
}

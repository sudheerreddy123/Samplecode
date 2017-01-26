using Microsoft.VisualStudio.TestTools.UnitTesting;
using consoleprogram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadeTest.Tests
{
    [TestClass]
    public class ReferenceTypetests
    {
        [TestMethod]
        public void referencetest()
        {
            Gradeclass book1 = new Gradeclass();
            Gradeclass book2 = book1;
            Giveabook(book2);
            Assert.AreSame("A great book",book1.Name);
            
            
        }
        private void Giveabook(Gradeclass book)
        {
            book.Name = "A great book";
        }

    }
}

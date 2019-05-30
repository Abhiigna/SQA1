using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1;
using NUnit.Framework;

namespace TestCase
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestCaseGetLength()
        {
            int ln = 7, wd = 8;
            Rectangle rec = new Rectangle(ln,wd);
            int len = rec.GetLength();
            Assert.AreEqual(len,ln);
        }
        [Test]
        public void TestCaseGetWidth()
        {
            int ln = 7, wd = 8;
            Rectangle rec = new Rectangle(ln, wd);
            int wid = rec.GetWidth();
            Assert.AreEqual(wid,wd);
        }
        [Test]
        public void TestCaseSetLength()
        {
            int ln = 7, wd = 8;
            Rectangle rec = new Rectangle(ln, wd);
            int len1 = rec.SetLenght(ln);
            Assert.AreEqual(len1,ln);
        }
        [Test]
        public void TestCaseSetWidth()
        {
            int ln = 7, wd = 8;
            Rectangle rec = new Rectangle(ln, wd);
            int wid1 = rec.SetWidth(wd);
            Assert.AreEqual(wid1,wd);
        }
        [Test]
        public void TestCaseGetPerimeter()
        {
            int ln = 7, wd = 8;
            Rectangle rec = new Rectangle(ln, wd);
            int peri = rec.GetPerimeter();
            Assert.AreEqual(peri, 2*(ln+wd));
        }
        [Test]
        public void TestCaseGetArea()
        {
            int ln = 7, wd = 8;
            Rectangle rec = new Rectangle(ln, wd);
            int area = rec.GetArea();
            Assert.AreEqual(area, ln*wd);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP.Tests
{
    [TestClass()]
    public class RationalTests
    {
        [TestMethod()]
        public void RationalTest()
        {
            try
            { Rational rational = new(4, 0); }
            catch { return; }
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest1()
        {
            Rational rational = new Rational(-7, 5);
            Assert.IsTrue(rational.ToString() == "-7/5");
        }

        [TestMethod()]
        public void ToStringTest2()
        {
            Rational rational = new Rational(-10, 5);
            Assert.IsTrue(rational.ToString() == "-2");
        }

        [TestMethod()]
        public void NOKTest()
        {
            Assert.IsTrue(Rational.NOK(2, 4) == Rational.NOK(2, -4));
        }

        [TestMethod()]
        public void NODTest()
        {
            Assert.IsTrue(Rational.NOD(15, 12) == Rational.NOD(12, -15));
        }
    }
}
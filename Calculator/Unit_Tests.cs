using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp2
{
    internal class Unit_Tests
    {
        private readonly double add = new Calculator('+', 5, -125).Calculate();
        private readonly double subst = new Calculator('-', 15, 10).Calculate();
        private readonly double mult = new Calculator('*', 25, 5).Calculate();
        private readonly double divisionnorm = new Calculator('/',15,3).Calculate();
        private readonly double divisionzero = new Calculator('/',15,0).Calculate();
        private readonly Calculator excep = new Calculator('d', 154, 2);
        [Test]
        public void Addition_Test()
        {
            Assert.That(add, Is.EqualTo(-120.00));
        }

        [Test]
        public void Substraction_Test()
        {
            Assert.That(subst, Is.EqualTo(5.00));
        }

        [Test]
        public void Multiplication_Test()
        {
            Assert.That(mult, Is.EqualTo(125.00));
        }

        [Test]
        public void Division_Normal_Test()
        {
            Assert.That(divisionnorm, Is.EqualTo(5.00));
        }

        [Test]
        public void Division_Zero_Test()
        {
            Assert.That(divisionzero, Is.EqualTo(0));
        }

        [Test]
        public void Exception_Test()
        {
            try
            {
                excep.Calculate();
            } catch (NotImplementedException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Unsupported operand!"));
            }
        }
    }
}

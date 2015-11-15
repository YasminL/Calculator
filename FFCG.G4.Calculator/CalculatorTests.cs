using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

//Ni skall bygga en enkel kalkylator som klarar av de fyra vanliga räknesätten. Den skulle kunna ha följande metoder:
//Add(...);
//Subtract(...);
//Multiply(...);
//Divide(...);

namespace FFCG.G4.Calculator

{
    [TestFixture]
    class CalculatorTests
    {
        private Calculator _calculator;
        const int FirstTerm = 10;
        const int SecondTerm = 2;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void term_plus_term_equals_sum()
        {
            int expected = 12;
            var actual = _calculator.add(FirstTerm, SecondTerm);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void term_minus_term_equals_diff()
        {
            int expected = 8;
            var actual = _calculator.subtract(FirstTerm, SecondTerm);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void factor_multiplied_with_factor_equals_product()
        {
            int expected = 20;
            var actual = _calculator.multiply(FirstTerm, SecondTerm);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void numerator_divided_by_denominator_equals_quotient()
        {
            int expected = 5;
            int actual = _calculator.divide(FirstTerm, SecondTerm);
            Assert.AreEqual(expected, actual);
        }
    }
}

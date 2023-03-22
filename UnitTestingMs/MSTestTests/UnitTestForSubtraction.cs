using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForSubtraction : MSTestBaseClass
    {
        Calculator calculator = new Calculator();
        [TestMethod]
        public void SubPositive()
        {
            var valueToSubstractFrom = 7;
            var valueToSubstract = 5;

            var result = calculator.Sub(valueToSubstractFrom, valueToSubstract);

            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void SubNegative()
        {
            var valueToSubstractFrom = -7;
            var valueToSubstract = -5;

            var result = calculator.Sub(valueToSubstractFrom, valueToSubstract);

            Assert.AreEqual(-2, result);
        }
    }
}
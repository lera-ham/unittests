using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForSubtraction : MSTestBaseClass
    {
        [TestMethod]
        public void Sub_PositiveNumbers_ReturnsCorrectValue()
        {
            var valueToSubstractFrom = 7;
            var valueToSubstract = 5;

            var result = calculator.Sub(valueToSubstractFrom, valueToSubstract);

            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Sub_NegativeNumbers_ReturnsCorrectValue()
        {
            var valueToSubstractFrom = -7;
            var valueToSubstract = -5;

            var result = calculator.Sub(valueToSubstractFrom, valueToSubstract);

            Assert.AreEqual(-2, result);
        }
    }
}
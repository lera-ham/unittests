using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForIsPositive : MSTestBaseClass
    {
        Calculator calculator = new Calculator();
        [TestMethod]
        public void IsPositiveForPositiveValue()
        {
            var valueToCalculate = 1;

            var result = calculator.isPositive(valueToCalculate);

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void IsPositiveForNegativeValue()
        {
            var valueToCalculate = -1;

            var result = calculator.isPositive(valueToCalculate);

            Assert.AreEqual(false, result);
        }
    }
}
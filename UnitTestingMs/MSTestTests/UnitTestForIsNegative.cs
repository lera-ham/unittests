using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForIsNegative : MSTestBaseClass
    {
        Calculator calculator = new Calculator();
        [TestMethod]
        public void IsNegativeForNegativeValue()
        {
            var valueToCalculate = -1;

            var result = calculator.isNegative(valueToCalculate);

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void IsNegativeForPositiveValue()
        {
            var valueToCalculate = 1;

            var result = calculator.isNegative(valueToCalculate);

            Assert.AreEqual(false, result);
        }
    }
}
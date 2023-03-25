using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForIsPositive : MSTestBaseClass
    {
        [TestMethod]
        public void IsPositive_PositiveNumber_ReturnsTrue()
        {
            var valueToCalculate = 1;

            var result = calculator.isPositive(valueToCalculate);

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void IsPositive_NegativeNumber_ReturnsFalse()
        {
            var valueToCalculate = -1;

            var result = calculator.isPositive(valueToCalculate);

            Assert.AreEqual(false, result);
        }
    }
}
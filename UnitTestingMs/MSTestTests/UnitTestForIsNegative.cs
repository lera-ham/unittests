using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForIsNegative : MSTestBaseClass
    {
        [TestMethod]
        public void IsNegative_NegativeNumber_ReturnsTrue()
        {
            var valueToCalculate = -1;

            var result = calculator.isNegative(valueToCalculate);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsNegative_PositiveNumber_ReturnsFalse()
        {
            var valueToCalculate = 1;

            var result = calculator.isNegative(valueToCalculate);

            Assert.AreEqual(false, result);
        }
    }
}
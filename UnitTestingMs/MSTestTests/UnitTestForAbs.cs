using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForAbs: MSTestBaseClass
    {
        [TestMethod]
        public void Abs_NegativeNumber_ReturnsAbsoluteValue()
        {
            var valueToCalculate = -3;

            var result = calculator.Abs(valueToCalculate);

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void Abs_PositiveNumber_ReturnsAbsoluteValue()
        {
            var valueToCalculate = 3;

            var result = calculator.Abs(valueToCalculate);

            Assert.AreEqual(3, result);
        }
    }
}
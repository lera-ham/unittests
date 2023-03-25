using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForSin : MSTestBaseClass
    {
        [TestMethod]
        public void Sin_ZeroNumber_ReturnsZero()
        {
            var valueToCalculate = 0;

            var result = calculator.Sin(valueToCalculate);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Sin_PositiveNumber_ReturnsTheSameValueAsMathClass()
        {
            var valueToCalculate = Math.PI / 4;

            var result = calculator.Sin(valueToCalculate);

            Assert.AreEqual(Math.Sin(valueToCalculate), result);
        }
    }
}
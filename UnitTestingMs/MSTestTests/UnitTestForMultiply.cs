using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForMultiply : MSTestBaseClass
    {
        [TestMethod]
        public void Multiply_PositiveNumbers_ReturnsCorrectValue()
        {
            var firstValueToMultiply = 7;
            var secondValueToMultiply = 4;

            var result = calculator.Multiply(firstValueToMultiply, secondValueToMultiply);

            Assert.AreEqual(28, result);
        }

        [TestMethod]
        public void Multiply_NegativeNumbers_ReturnsCorrectValue()
        {
            var firstValueToMultiply = -7;
            var secondValueToMultiply = -4;

            var result = calculator.Multiply(firstValueToMultiply, secondValueToMultiply);

            Assert.AreEqual(28, result);
        }
    }
}
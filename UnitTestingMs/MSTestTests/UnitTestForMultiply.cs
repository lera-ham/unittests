using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForMultiply : MSTestBaseClass
    {
        [TestMethod]
        public void MultiplyPositive()
        {
            var firstValueToMultiply = 7;
            var secondValueToMultiply = 4;

            var result = calculator.Multiply(firstValueToMultiply, secondValueToMultiply);

            Assert.AreEqual(28, result);
        }
        [TestMethod]
        public void MultiplyNegative()
        {
            var firstValueToMultiply = -7;
            var secondValueToMultiply = -4;

            var result = calculator.Multiply(firstValueToMultiply, secondValueToMultiply);

            Assert.AreEqual(28, result);
        }
    }
}
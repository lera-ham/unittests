using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForSqrt : MSTestBaseClass
    {
        [TestMethod]
        public void Sqrt_OneDigitNumber_ReturnsCorrectValue()
            
        {
            var valueToHaveSqrtFrom = 9;

            var result = calculator.Sqrt(valueToHaveSqrtFrom);

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void Sqrt_FourDigitNumber_ReturnsCorrectValue()
        {
            var valueToHaveSqrtFrom = 10000;

            var result = calculator.Sqrt(valueToHaveSqrtFrom);

            Assert.AreEqual(100, result);
        }
    }
}
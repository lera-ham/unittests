using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForSqrt : MSTestBaseClass
    {
        Calculator calculator = new Calculator();
        [TestMethod]
        public void SqrtSmallValue()
        {
            var valueToHaveSqrtFrom = 9;

            var result = calculator.Sqrt(valueToHaveSqrtFrom);

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void SqrtBigValue()
        {
            var valueToHaveSqrtFrom = 10000;

            var result = calculator.Sqrt(valueToHaveSqrtFrom);

            Assert.AreEqual(100, result);
        }
    }
}
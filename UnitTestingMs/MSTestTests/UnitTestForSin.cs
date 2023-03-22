using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForSin : MSTestBaseClass
    {
        Calculator calculator = new Calculator();
        [TestMethod]
        public void SinOfZero()
        {
            var valueToCalculate = 0;

            var result = calculator.Sin(valueToCalculate);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void SinOfPositiveValue()
        {
            var valueToCalculate = Math.PI / 4;

            var result = calculator.Sin(valueToCalculate);

            Assert.AreEqual(Math.Sin(valueToCalculate), result);
        }
    }
}
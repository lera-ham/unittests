using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForAbs: MSTestBaseClass
    {
        Calculator calculator = new Calculator();
        [TestMethod]
        public void AbsForNegative()
        {
            var valueToCalculate = -3;

            var result = calculator.Abs(valueToCalculate);

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void AbsForPositive()
        {
            var valueToCalculate = 3;

            var result = calculator.Abs(valueToCalculate);

            Assert.AreEqual(3, result);
        }
    }
}
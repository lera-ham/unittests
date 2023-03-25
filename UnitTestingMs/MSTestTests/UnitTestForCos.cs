using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForCos : MSTestBaseClass
    {
        [TestMethod]
        public void Cos_ZeroNumber_ReturnsOne()
        {
            var valueToCalculate = 0;

            var result = calculator.Cos(valueToCalculate);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Cos_PositiveNumber_ReturnsTheSameValueAsMathClass()
        { 
            var valueToCalculate = Math.PI/4;

            var result = calculator.Cos(valueToCalculate);

            Assert.AreEqual(Math.Cos(valueToCalculate), result);
        }
    }
}
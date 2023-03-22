using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForCos : MSTestBaseClass
    {
        Calculator calculator = new Calculator();
        [TestMethod]
        public void CosOfZero()
        {
            var valueToCalculate = 0;

            var result = calculator.Cos(valueToCalculate);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void CosOfPositiveValue()
        { 
            var valueToCalculate = Math.PI/4;

            var result = calculator.Cos(valueToCalculate);

            Assert.AreEqual(Math.Cos(valueToCalculate), result);
        }
    }
}
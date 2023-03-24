using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForPow : MSTestBaseClass
    {
        [TestMethod]
        public void PowPositive()
        {
            int valueToBeRaised = 1;
            double powerValueDouble = Convert.ToDouble(6);

            var result = calculator.Pow(valueToBeRaised, powerValueDouble);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void PowNegative()
        {
            int valueToBeRaised = -1;
            double powerValueDouble = Convert.ToDouble(5);

            var result = calculator.Pow(valueToBeRaised, powerValueDouble);

            Assert.AreEqual(-1, result);
        }
    }
}
using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForSum : MSTestBaseClass
    {
        [TestMethod]
        public void SumPositive()
        {
            var firstValueToAdd = 1;
            double firstValueToAddDouble = Convert.ToDouble(firstValueToAdd);
            var secondValueToAdd = 6;
            double secondValueToAddDouble = Convert.ToDouble(secondValueToAdd);

            var result = calculator.Add(secondValueToAddDouble, firstValueToAddDouble);

            Assert.AreEqual(7, result);
        }
        [TestMethod]
        public void SumNegative()
        {
            var firstValueToAdd = -1;
            double firstValueToAddDouble = Convert.ToDouble(firstValueToAdd);
            var secondValueToAdd = -6;
            double secondValueToAddDouble = Convert.ToDouble(secondValueToAdd);

            var result = calculator.Add(secondValueToAddDouble, firstValueToAddDouble);

            Assert.AreEqual(-7, result);
        }
    }
}

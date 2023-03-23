using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTestForIsPositive : NUnitBaseClass
    {
        Calculator calculator = new Calculator();
        [Test]
        public void IsPositive()
        {
            var valueToCalculate = 1;

            var result = calculator.isPositive(valueToCalculate);

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void IsPositiveForNegativeValue()
        {
            var valueToCalculate = -1;

            var result = calculator.isPositive(valueToCalculate);

            Assert.AreEqual(false, result);
        }
    }
}
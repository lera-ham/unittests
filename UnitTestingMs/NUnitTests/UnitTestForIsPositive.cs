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
        [Test]
        public void IsPositive_PositiveNumber_ReturnsTrue()
        {
            var valueToCalculate = 1;

            var result = calculator.isPositive(valueToCalculate);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPositive_NegativeNumber_ReturnsFalse()
        {
            var valueToCalculate = -1;

            var result = calculator.isPositive(valueToCalculate);

            Assert.AreEqual(false, result);
        }
    }
}
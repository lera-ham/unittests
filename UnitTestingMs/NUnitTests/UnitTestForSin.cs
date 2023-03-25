using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTestForSin : NUnitBaseClass
    {
        [Test]
        public void Sin_ZeroNumber_ReturnsZero()
        {
            var valueToCalculate = 0;

            var result = calculator.Sin(valueToCalculate);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Sin_PositiveNumber_ReturnsTheSameValueAsMathClass()
        {
            var valueToCalculate = Math.PI / 4;

            var result = calculator.Sin(valueToCalculate);

            Assert.AreEqual(Math.Sin(valueToCalculate), result);
        }
    }
}
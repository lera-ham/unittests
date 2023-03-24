using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTestForIsNegative : NUnitBaseClass
    {
        [Test]
        public void IsNegativeForNegativeValue()
        {
            var valueToCalculate = -1;

            var result = calculator.isNegative(valueToCalculate);

            Assert.AreEqual(true, result);
        }
        [Test]
        public void IsNegativeForPositiveValue()
        {
            var valueToCalculate = 1;

            var result = calculator.isNegative(valueToCalculate);

            Assert.AreEqual(false, result);
        }
    }
}
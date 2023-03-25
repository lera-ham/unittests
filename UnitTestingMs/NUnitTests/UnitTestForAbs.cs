using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
   // [Parallelizable(ParallelScope.All)]
    public class UnitTestForAbs: NUnitBaseClass
    {
        [Test]
        public void Abs_NegativeNumber_ReturnsAbsoluteValue()
        {
            var valueToCalculate = -3;

            var result = calculator.Abs(valueToCalculate);

            Assert.AreEqual(3, result);
        }
        [Test]
        public void Abs_PositiveNumber_ReturnsAbsoluteValue()
        {
            var valueToCalculate = 3;

            var result = calculator.Abs(valueToCalculate);

            Assert.AreEqual(3, result);
        }
    }
}
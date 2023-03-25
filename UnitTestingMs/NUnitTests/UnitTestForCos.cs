using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTestForCos : NUnitBaseClass
    {
        [Test]
        public void Cos_ZeroNumber_ReturnsOne()
        {
            var valueToCalculate = 0;

            var result = calculator.Cos(valueToCalculate);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void Cos_PositiveNumber_ReturnsTheSameValueAsMathClass()
        {
            var valueToCalculate = Math.PI / 4;

            var result = calculator.Cos(valueToCalculate);

            Assert.AreEqual(Math.Cos(valueToCalculate), result);
        }
    }
}
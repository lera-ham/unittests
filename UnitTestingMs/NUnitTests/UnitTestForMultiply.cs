using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTestForMultiply : NUnitBaseClass
    {
        [Test]
        public void Multiply_PositiveNumbers_ReturnsCorrectValue()
        {
            var firstValueToMultiply = 7;
            var secondValueToMultiply = 4;

            var result = calculator.Multiply(firstValueToMultiply, secondValueToMultiply);

            Assert.AreEqual(28, result);
        }

        [Test]
        public void Multiply_NegativeNumbers_ReturnsCorrectValue()
        {
            var firstValueToMultiply = -7;
            var secondValueToMultiply = -4;

            var result = calculator.Multiply(firstValueToMultiply, secondValueToMultiply);

            Assert.AreEqual(28, result);
        }
    }
}
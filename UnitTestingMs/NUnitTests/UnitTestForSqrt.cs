using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTestForSqrt : NUnitBaseClass
    {
            [Test]
            public void Sqrt_OneDigitNumber_ReturnsCorrectValue()
            {
                var valueToHaveSqrtFrom = 9;

                var result = calculator.Sqrt(valueToHaveSqrtFrom);

                Assert.AreEqual(3, result);
            }

            [Test]
            public void Sqrt_FourDigitNumber_ReturnsCorrectValue()
            {
                var valueToHaveSqrtFrom = 10000;

                var result = calculator.Sqrt(valueToHaveSqrtFrom);

                Assert.AreEqual(100, result);
            }
        }
}
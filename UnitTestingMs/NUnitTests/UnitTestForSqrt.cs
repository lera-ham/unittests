using System;
using CSharpCalculator;
using MSTestTests;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTestForSqrt : NUnitBaseClass
    {
            Calculator calculator = new Calculator();
            [Test]
            public void SqrtSmallValue()
            {
                var valueToHaveSqrtFrom = 9;

                var result = calculator.Sqrt(valueToHaveSqrtFrom);

                Assert.AreEqual(3, result);
            }
            [Test]
            public void SqrtBigValue()
            {
                var valueToHaveSqrtFrom = 10000;

                var result = calculator.Sqrt(valueToHaveSqrtFrom);

                Assert.AreEqual(100, result);
            }
        }
}
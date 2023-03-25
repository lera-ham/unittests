using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTestForSubtraction : NUnitBaseClass
    {
        [TestMethod]
        public void Sub_PositiveNumbers_ReturnsCorrectValue()
        {
            var valueToSubstractFrom = 7;
            var valueToSubstract = 5;

            var result = calculator.Sub(valueToSubstractFrom, valueToSubstract);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Sub_NegativeNumbers_ReturnsCorrectValue()
        {
            var valueToSubstractFrom = -7;
            var valueToSubstract = -5;

            var result = calculator.Sub(valueToSubstractFrom, valueToSubstract);

            Assert.AreEqual(-2, result);
        }
    }
}
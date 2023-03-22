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
        Calculator calculator = new Calculator();
        [TestMethod]
        public void SubPositive()
        {
            var valueToSubstractFrom = 7;
            var valueToSubstract = 5;

            var result = calculator.Sub(valueToSubstractFrom, valueToSubstract);

            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void SubNegative()
        {
            var valueToSubstractFrom = -7;
            var valueToSubstract = -5;

            var result = calculator.Sub(valueToSubstractFrom, valueToSubstract);

            Assert.AreEqual(-2, result);
        }
    }
}
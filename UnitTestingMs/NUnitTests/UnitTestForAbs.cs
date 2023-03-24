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
        public void AbsAbsForNegative()
        {
            var valueToCalculate = -3;

            var result = calculator.Abs(valueToCalculate);

            Assert.AreEqual(3, result);
        }
        [Test]
        public void AbsAbsForPositive()
        {
            var valueToCalculate = 3;

            var result = calculator.Abs(valueToCalculate);

            Assert.AreEqual(3, result);
        }
    }
}
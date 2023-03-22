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
        Calculator calculator = new Calculator();
        [Test]
        public void SinOfZero()
        {
            var valueToCalculate = 0;

            var result = calculator.Sin(valueToCalculate);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void SinOfPositiveValue()
        {
            var valueToCalculate = Math.PI / 4;

            var result = calculator.Sin(valueToCalculate);

            Assert.AreEqual(Math.Sin(valueToCalculate), result);
        }
    }
}
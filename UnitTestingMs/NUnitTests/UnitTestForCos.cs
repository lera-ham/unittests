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
        Calculator calculator = new Calculator();
        [Test]
        public void CosOfZero()
        {
            var valueToCalculate = 0;

            var result = calculator.Cos(valueToCalculate);

            Assert.AreEqual(1, result);
        }
        [Test]
        public void CosOfPositiveValue()
        {
            var valueToCalculate = Math.PI / 4;

            var result = calculator.Cos(valueToCalculate);

            Assert.AreEqual(Math.Cos(valueToCalculate), result);
        }
    }
}
using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTestForPow : NUnitBaseClass
    {
        [Test]
        public void Pow_PositiveNumberEvenDegree_ReturnsCorrectValue()
        {
            int valueToBeRaised = 1;
            double powerValueDouble = Convert.ToDouble(6);

            var result = calculator.Pow(valueToBeRaised, powerValueDouble);

            Assert.AreEqual(1, result);
        }
        [Test]
        public void Pow_NegativeNumberOddDegree_ReturnsCorrectValue()
        {
            int valueToBeRaised = -1;
            double powerValueDouble = Convert.ToDouble(5);

            var result = calculator.Pow(valueToBeRaised, powerValueDouble);

            Assert.AreEqual(-1, result);
        }
    }
}
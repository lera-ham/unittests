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
        Calculator calculator = new Calculator();
        [Test]
        public void PowPositive()
        {
            int valueToBeRaised = 1;
            double powerValueDouble = Convert.ToDouble(6);

            var result = calculator.Pow(valueToBeRaised, powerValueDouble);

            Assert.AreEqual(1, result);
        }
        [Test]
        public void PowNegative()
        {
            int valueToBeRaised = -1;
            double powerValueDouble = Convert.ToDouble(5);

            var result = calculator.Pow(valueToBeRaised, powerValueDouble);

            Assert.AreEqual(-1, result);
        }
    }
}
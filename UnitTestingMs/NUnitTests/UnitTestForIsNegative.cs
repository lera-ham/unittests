using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTestForIsNegative
    {
        [SetUp]
        public void TestSetup()
        {
            Console.Out.WriteLine("Starting test for method isNegative!");
        }

        [Test]
        public void isNegative()
        {
            Calculator calculator = new Calculator();
            var valueToCalculate = -1;

            var result = calculator.isNegative(valueToCalculate);

            Assert.AreEqual(true, result);
        }

        [TearDown]
        public void TestCleanup()
        {
            Console.Out.WriteLine("Finished!");
        }

    }
}
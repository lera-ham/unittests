using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTestForIsPositive
    {
        [SetUp]
        public void TestSetup()
        {
            Console.Out.WriteLine("Starting test for method isPositive!");
        }
        [Test]
        public void isPositive()
        {
            Calculator calculator = new Calculator();
            var valueToCalculate = 1;

            var result = calculator.isPositive(valueToCalculate);

            Assert.AreEqual(true, result);
        }
        [TearDown]
        public void TestCleanup()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
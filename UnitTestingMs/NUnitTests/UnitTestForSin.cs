using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTestForSin
    {
        [SetUp]
        public void TestSetup()
        {
            Console.Out.WriteLine("Starting test for method Sin!");
        }
        [Test]
        public void Sin()
        {
            Calculator calculator = new Calculator();
            var valueToCalculate = 0;

            var result = calculator.Sin(valueToCalculate);

            Assert.AreEqual(0, result);
        }
        [TearDown]
        public void TestCleanup()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
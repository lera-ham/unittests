using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTestForAbs
    {
        [SetUp]
        public void TestSetup()
        {
            Console.Out.WriteLine("Starting test for method Abs!");
        }

        [Test]
        public void Abs()
        {
            Calculator calculator = new Calculator();
            var valueToCalculate = -3;

            var result = calculator.Abs(valueToCalculate);

            Assert.AreEqual(3, result);
        }

        [TearDown]
        public void TestCleanup()
        {
            Console.Out.WriteLine("Finished!");
        }

    }
}
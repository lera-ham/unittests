using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTestForCos
    {
        [SetUp]
        public void TestSetup()
        {
            Console.Out.WriteLine("Starting test for method Cos!");
        }

        [Test]
        public void Cos()
        {
            Calculator calculator = new Calculator();
            var valueToCalculate = 0;

            var result = calculator.Cos(valueToCalculate);

            Assert.AreEqual(1, result);
        }

        [TearDown]
        public void TestCleanup()
        {
            Console.Out.WriteLine("Finished!");
        }

    }
}
using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTestForMultiply
    {
        [SetUp]
        public void TestSetup()
        {
            Console.Out.WriteLine("Starting test for method Multiply!");
        }

        [Test]
        public void Multiply()
        {
            Calculator calculator = new Calculator();
            var firstValueToMultiply = 7;
            var secondValueToMultiply = 4;

            var result = calculator.Multiply(firstValueToMultiply, secondValueToMultiply);

            Assert.AreEqual(28, result);
        }

        [TearDown]
        public void TestCleanup()
        {
            Console.Out.WriteLine("Finished!");
        }

    }
}


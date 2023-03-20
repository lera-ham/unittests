using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTestForSubtraction
    {
        [SetUp]
        public void TestSetup()
        {
            Console.Out.WriteLine("Starting test for method Sub!");
        }

        [Test]
        public void Sub()
        {
            Calculator calculator = new Calculator();
            var valueToSubstractFrom = 7;
            var valueToSubstract = 5;

            var result = calculator.Sub(valueToSubstractFrom, valueToSubstract);

            Assert.AreEqual(2, result);
        }

        [TearDown]
        public void TestCleanup()
        {
            Console.Out.WriteLine("Finished!");
        }

    }
}


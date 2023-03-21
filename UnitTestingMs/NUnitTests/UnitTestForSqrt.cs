using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTestForSqrt
    {
        [SetUp]
        public void TestSetup()
        {
            Console.Out.WriteLine("Starting test for method Sqrt!");
        }
        [Test]
        public void Sqrt()
        {
            Calculator calculator = new Calculator();
            var valueToHaveSqrtFrom = 9;

            var result = calculator.Sqrt(valueToHaveSqrtFrom);

            Assert.AreEqual(3, result);
        }
        [TearDown]
        public void TestCleanup()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
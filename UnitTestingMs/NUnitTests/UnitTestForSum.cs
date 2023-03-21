using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTestForSum
    {
        [SetUp]
        public void TestSetup()
        {
            Console.Out.WriteLine("Starting test for method Sum!");
        }
        [Test]
        public void Sum()
        {
            Calculator calculator = new Calculator();
            var firstValueToAdd = 1;
            double firstValueToAddDouble = Convert.ToDouble(firstValueToAdd);
            var secondValueToAdd = 6;
            double secondValueToAddDouble = Convert.ToDouble(secondValueToAdd);

            var result = calculator.Add(secondValueToAddDouble, firstValueToAddDouble);

            Assert.AreEqual(7, result);
        }
        [TearDown]
        public void TestCleanup()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}

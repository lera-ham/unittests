using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTestForPow
    {
        [SetUp]
        public void TestSetup()
        {
            Console.Out.WriteLine("Starting test for method Pow!");
        }
        [Test]
        public void Pow()
        {
            Calculator calculator = new Calculator();
            int valueToBeRaised = 1;
            double powerValueDouble = Convert.ToDouble(6);

            var result = calculator.Pow(valueToBeRaised, powerValueDouble);

            Assert.AreEqual(1, result);
        }
        [TearDown]
        public void TestCleanup()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
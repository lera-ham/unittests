using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
   // [Parallelizable]
    public class UnitTestForDivide
    {
        [SetUp]
        public void TestSetup()
        {
            Console.Out.WriteLine("Starting test for method Divide!");
        }
        [Test]
        [TestCase(3, 3, 1)]
        [TestCase(4, 2, 2)]
        [TestCase("14", 1, 14)]
        public void Divide(int n, int d, int q)
        {
            Calculator calculator = new Calculator();

            var result = calculator.Divide(n, d);

            Assert.AreEqual(q, result);
        }
        [TearDown]
        public void TestCleanup()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
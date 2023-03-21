using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForSqrt
    {
        [TestInitialize]
        public void TestInit()
        {
            Console.Out.WriteLine("Starting test for method Sqrt!");
        }
        [TestMethod]
        public void Sqrt()
        {
            Calculator calculator = new Calculator();
            var valueToHaveSqrtFrom = 9;

            var result = calculator.Sqrt(valueToHaveSqrtFrom);

            Assert.AreEqual(3, result);
        }
        [TestCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
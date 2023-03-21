using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForIsNegative
    {
        [TestInitialize]
        public void TestInit()
        {
            Console.Out.WriteLine("Starting test for method isNegative!");
        }
        [TestMethod]
        public void isNegative()
        {
            Calculator calculator = new Calculator();
            var valueToCalculate = -1;

            var result = calculator.isNegative(valueToCalculate);

            Assert.AreEqual(true, result);
        }
        [TestCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
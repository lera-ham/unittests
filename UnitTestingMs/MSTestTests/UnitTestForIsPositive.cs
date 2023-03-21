using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForIsPositive
    {
        [TestInitialize]
        public void TestInit()
        {
            Console.Out.WriteLine("Starting test for method isPositive!");
        }
        [TestMethod]
        public void isPositive()
        {
            Calculator calculator = new Calculator();
            var valueToCalculate = 1;

            var result = calculator.isPositive(valueToCalculate);

            Assert.AreEqual(true, result);
        }
        [TestCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
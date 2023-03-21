using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForSin
    {
        [TestInitialize]
        public void TestInit()
        {
            Console.Out.WriteLine("Starting test for method Sin!");
        }
        [TestMethod]
        public void Sin()
        {
            Calculator calculator = new Calculator();
            var valueToCalculate = 0;

            var result = calculator.Sin(valueToCalculate);

            Assert.AreEqual(0, result);
        }
        [TestCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
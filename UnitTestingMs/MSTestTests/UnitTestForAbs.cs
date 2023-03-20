using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForAbs
    {
        [TestInitialize]
        public void TestInit()
        {
            Console.Out.WriteLine("Starting test for method Abs!");
        }

        [TestMethod]
        public void Abs()
        {
            Calculator calculator = new Calculator();
            var valueToCalculate = -3;

            var result = calculator.Abs(valueToCalculate);

            Assert.AreEqual(3, result);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
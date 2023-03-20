using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForCos
    {
        [TestInitialize]
        public void TestInit()
        {
            Console.Out.WriteLine("Starting test for method Cos!");
        }

        [TestMethod]
        public void Cos()
        {
            Calculator calculator = new Calculator();
            var valueToCalculate = 0;

            var result = calculator.Cos(valueToCalculate);

            Assert.AreEqual(1, result);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }

    }
}
using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForSubtraction
    {
        [TestInitialize]
        public void TestInit()
        {
            Console.Out.WriteLine("Starting test for method Sub!");
        }
        [TestMethod]
        public void Sub()
        {
            Calculator calculator = new Calculator();
            var valueToSubstractFrom = 7;
            var valueToSubstract = 5;

            var result = calculator.Sub(valueToSubstractFrom, valueToSubstract);

            Assert.AreEqual(2, result);
        }
        [TestCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForPow
    {
        [TestInitialize]
        public void TestInit()
        {
            Console.Out.WriteLine("Starting test for method Pow!");
        }
        [TestMethod]
        public void Pow()
        {
            Calculator calculator = new Calculator();
            int valueToBeRaised = 1;
            double powerValueDouble = Convert.ToDouble(6);

            var result = calculator.Pow(valueToBeRaised, powerValueDouble);

            Assert.AreEqual(1, result);
        }
        [TestCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
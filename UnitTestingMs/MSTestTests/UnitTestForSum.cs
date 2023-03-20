using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForSum
    {
        [TestInitialize]
        public void TestInit()
        {
            Console.Out.WriteLine("Starting test for method Sum!");
        }

        [TestMethod]
        public void Sum()
        {
            Calculator calculator = new Calculator();
            var firstValueToAdd = 1;
            double firstValueToAddDouble = Convert.ToDouble(firstValueToAdd);
            var secondValueToAdd = 6;
            double secondValueToAddDouble = Convert.ToDouble(secondValueToAdd);

            var result = calculator.Add(secondValueToAddDouble, firstValueToAddDouble);

            Assert.AreEqual(7, result);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}

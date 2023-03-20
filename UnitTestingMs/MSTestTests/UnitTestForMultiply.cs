using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForMultiply
    {
        [TestInitialize]
        public void TestInit()
        {
            Console.Out.WriteLine("Starting test for method Multiply!");
        }

        [TestMethod]
        public void Multiply()
        {
            Calculator calculator = new Calculator();
            var firstValueToMultiply = 7;
            var secondValueToMultiply = 4;

            var result = calculator.Multiply(firstValueToMultiply, secondValueToMultiply);

            Assert.AreEqual(28, result);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}


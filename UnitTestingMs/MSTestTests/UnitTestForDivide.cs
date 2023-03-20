using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    // [Parallelizable]
    public class UnitTestForDivide
    {
        [TestInitialize]
        public void TestInit()
        {
            Console.Out.WriteLine("Starting test for method Divide!");
        }

        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(12, 4, 3)]
        [DataRow("14", 1, 14)]
        public void Divide(int n, int d, int q)
        {
            Calculator calculator = new Calculator();
            int dividedValueInt = Convert.ToInt32(n);
            int dividedForValueInt = Convert.ToInt32(d);

            var result = calculator.Divide(dividedValueInt, dividedForValueInt);
            int resultInt = Convert.ToInt32(result);

            Assert.AreEqual(q, resultInt);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
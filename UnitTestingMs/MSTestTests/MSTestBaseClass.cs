using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class MSTestBaseClass
    {
        public Calculator calculator;
        [ClassInitialize]
        public void TestInit()
        {
          calculator = new Calculator();
          Console.Out.WriteLine("Starting test!");
        }
        [ClassCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
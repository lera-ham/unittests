using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class MSTestBaseClass
    {public TestContext TestContext { get; set; }
        [TestInitialize]
        public void TestInit()
        {
            Console.Out.WriteLine("Starting test!");
        }
        [TestCleanup]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
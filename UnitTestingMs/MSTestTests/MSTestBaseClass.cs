using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class MSTestBaseClass
    {
        public static Calculator calculator;
        [ClassInitialize(InheritanceBehavior.BeforeEachDerivedClass)]
        public static void TestInit(TestContext testContext)
        {
          calculator = new Calculator();
          Console.Out.WriteLine("Starting test!");
        }
        [ClassCleanup(InheritanceBehavior.BeforeEachDerivedClass)]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
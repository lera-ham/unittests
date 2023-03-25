using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    public class NUnitBaseClass
    {
        public Calculator calculator;

        [SetUp]
        public void TestInit()
        {
            calculator = new Calculator();
            Console.Out.WriteLine("Starting test!");
        }

        [TearDown]
        public void CleanUp()
        {
            Console.Out.WriteLine("Finished!");
        }
    }
}
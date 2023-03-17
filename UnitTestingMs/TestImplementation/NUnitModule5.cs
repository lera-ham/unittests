using System;
using System.Reflection;
using System.Xml.Linq;
using NUnit.Framework;
using CSharpCalculator;
using Assert = NUnit.Framework.Assert;

namespace TestProjectNew
{

    [TestFixture]
   // [Parallelizable]
    public class NUnitModule5
    {
        public Calculator calculator;

        [OneTimeSetUp]
        public void ClassInit()
        {

          Calculator calculator = new Calculator();
        }

        [SetUp]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Sub()
        {
            Assert.AreEqual(2, calculator.Sub(7, 5));
        }

        [Test]
        public void Multiply()
        {
            Assert.AreEqual(28, calculator.Multiply(4, 7));
        }

        [Test]
        public void Sum()
        {
            int x = 1;
            double y = Convert.ToDouble(x);
            int a = 6;
            double b = Convert.ToDouble(a);

            Assert.AreEqual(7, calculator.Add(y,b));
        }

        [Test]
        [TestCase(3, 3, 1)]
        [TestCase(4, 2, 2)]
        [TestCase("14", 1, 14)]

        public void Divide(int n, int d, int q)
        {
            Assert.AreEqual(q, calculator.Divide(n, d));

        }

        [Test]
        public void Sqrt()
        {
            Assert.AreEqual(3, calculator.Sqrt("9"));
        }

        [Test]
        public void Pow()
        {
            int x = 1;
            double y = Convert.ToDouble(6);

            Assert.AreEqual(1, calculator.Pow(x, y));
        }

        [Test]
        public void Abs()
        {
            Assert.AreEqual(3, calculator.Abs("-3"));
        }

        [Test]
        public void Sin()
        {
            Assert.AreEqual(0, calculator.Sin(0));
        }

        [Test]
        public void Cos()
        {
            Assert.AreEqual(1, calculator.Cos(0));
        }

        [Test]
        public void isPositive()
        {
            Assert.AreEqual(true, calculator.isPositive(1));
        }

        [Test]
        public void isNegative()
        {
            Assert.AreEqual(true, calculator.isNegative(-1));
        }

        [TearDown]
        public static void TestClean()
        {
            Console.WriteLine("OK");
        }

        [OneTimeTearDown]
        public static void ClassClean()
        {
            Console.WriteLine("OK");
        }
    }
}
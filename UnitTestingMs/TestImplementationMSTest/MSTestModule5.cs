using System;
using System.Reflection;
using System.Xml.Linq;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProjectNew
{

    [TestClass]
    public class MSTestModule5
    {
        public Calculator calculator;
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInit()
        {
            Calculator calculator = new Calculator();

    }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestMethod]
        public void Sub()
        {
            Assert.AreEqual(2, calculator.Sub("7", 5));
        }

        [TestMethod]
        public void Multiply()
        {
            Assert.AreEqual(28, calculator.Multiply(4, 7));
        }

        [TestMethod]
        public void Sum()
        {
            string x = "1";
            double y = Convert.ToDouble(x);
            int a = 6;
            double b = Convert.ToDouble(a);

            Assert.AreEqual(7, calculator.Add(y, b));
        }

        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(12, 4, 3)]
        [DataRow("14", 1, 14)]
          public void Divide(int n, int d, int q)

        {
            Assert.AreEqual(q, calculator.Divide(n, d));

        }

        [TestMethod]
        public void Sqrt()
        {
            Assert.AreEqual(3, calculator.Sqrt(9));
        }

        [TestMethod]
        public void Pow()
        {
            int x = 1;
            double y = Convert.ToDouble(6);

            Assert.AreEqual(1, calculator.Pow(x, y));
        }

        [TestMethod]
        public void Abs()
        {
            Assert.AreEqual(3, calculator.Abs(-3));
        }

        [TestMethod]
        public void Sin()
        {
            Assert.AreEqual(0, calculator.Sin(0));
        }

        [TestMethod]
        public void Cos()
        {
            Assert.AreEqual(1, calculator.Cos(0));
        }

        [TestMethod]
        public void isPositive()
        {
            Assert.AreEqual(true, calculator.isPositive(1));
        }

        [TestMethod]
        public void isNegative()
        {
            Assert.AreEqual(true, calculator.isNegative(-1));
        }

        [TestCleanup]
        public void CleanUp()
        {
            Console.WriteLine("OK");
        }

        [ClassCleanup]
        public void ClassClean()
        {
            Console.WriteLine("OK");
        }

    }
}
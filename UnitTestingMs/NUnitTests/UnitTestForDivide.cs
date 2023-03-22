﻿using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTestForDivide : NUnitBaseClass
    {
        Calculator calculator = new Calculator();
        [Test]
        [TestCase(3, 3, 1)]
        [TestCase(4, 2, 2)]
        [TestCase("14", 1, 14)]
        public void Divide(int n, int d, int q)
        {
            var result = calculator.Divide(n, d);

            Assert.AreEqual(q, result);
        }
        [Test]
        public void DivideNegative()
        {
            var valueToDivide = -3;
            var divisor = -1;
            var result = calculator.Divide(valueToDivide, divisor);

            Assert.AreEqual(3, result);
        }
    }
}
﻿using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTests
{
    [TestClass]
    public class UnitTestForDivide : MSTestBaseClass
    {
        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(12, 4, 3)]
        [DataRow(14, 1, 14)]
        public void Divide_PositiveNumbers_ReturnsCorrectValue(int n, int d, int q)
        {
            var result = calculator.Divide(n, d);

            Assert.AreEqual(q, result);
        }

        [TestMethod]
        public void Divide_NegativeNumbers_ReturnsCorrectValue()
        {
            var valueToDivide = -3;
            var divisor = -1;
            var result = calculator.Divide(valueToDivide, divisor);

            Assert.AreEqual(3, result);
        }
    }
}
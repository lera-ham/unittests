﻿using System;
using CSharpCalculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

[assembly:LevelOfParallelism(3)]
namespace NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTestForSum : NUnitBaseClass
    {
        [Test]
        public void Sum_PositiveNumbers_ReturnsCorrectValue()
        {
            var firstValueToAdd = 1;
            double firstValueToAddDouble = Convert.ToDouble(firstValueToAdd);
            var secondValueToAdd = 6;
            double secondValueToAddDouble = Convert.ToDouble(secondValueToAdd);

            var result = calculator.Add(secondValueToAddDouble, firstValueToAddDouble);

            Assert.AreEqual(7, result);
        }

        [Test]
        public void Sum_NegativeNumbers_ReturnsCorrectValue()
        {
            var firstValueToAdd = -1;
            double firstValueToAddDouble = Convert.ToDouble(firstValueToAdd);
            var secondValueToAdd = -6;
            double secondValueToAddDouble = Convert.ToDouble(secondValueToAdd);

            var result = calculator.Add(secondValueToAddDouble, firstValueToAddDouble);

            Assert.AreEqual(-7, result);
        }
    }
}
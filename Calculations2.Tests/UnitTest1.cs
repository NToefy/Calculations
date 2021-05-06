using Calculations;
using System;
using System.Collections.Generic;
using Xunit;

namespace Calculations2.Tests
{
    public class CalculatorFixture
    {
        public Calculator Calc => new Calculator();
    }
    public class UnitTest1 : IClassFixture<CalculatorFixture> // Use fixture to eliminate need to recreate objects all the time
    {
        private readonly CalculatorFixture _calculatorFixture;

        public UnitTest1(CalculatorFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            //var calc = new Calculator();
            var calc = _calculatorFixture.Calc;
            var result = calc.Add(1,2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.AddDouble(1.2, 3.5);
            Assert.Equal(4.7, result);
        }

        [Fact]
        [Trait("Category", "FiboTests")]
        public void FiboDoesNotIncludeZero()
        {
            var calc = _calculatorFixture.Calc;
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "FiboTests")]
        public void FiboIncludes()
        {
            var calc = _calculatorFixture.Calc;
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "FiboTests")]
        public void FiboNotInclude4()
        {
            var calc = _calculatorFixture.Calc;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "FiboTests")]
        public void CheckFiboCollection()
        {
            var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            var calc = _calculatorFixture.Calc;
            Assert.Equal(expectedCollection, calc.FiboNumbers);
        }

        [Fact]
        public void IsOdd_GivenOddValue_ReturnsTrue()
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.IsOdd(3);
            Assert.Equal(true, result);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, false)]
        [InlineData(3, true)]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }
    }
}

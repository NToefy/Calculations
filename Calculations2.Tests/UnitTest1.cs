using Calculations;
using System;
using Xunit;

namespace Calculations2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = new Calculator();
            var result = calc.Add(1,2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.2, 3.5);
            Assert.Equal(4.7, result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculations;

namespace Calculations2.Tests
{
    public class NamesTest
    {
        [Fact]

        public void MakeFullName_GivenString_ReturnEqual()
        {
            var names = new Names();
            var result = names.MakeFullName("joe", "Black");
            Assert.Equal("Joe Black", result, ignoreCase:true);
            Assert.Contains("joe", result);
        }
    }
}

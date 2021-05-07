using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations2.Tests
{
    public static class TestDataShare
    {
        public static IEnumerable<object[]> IsOddOrEvenData
        {
            get
            {
                yield return new object[] {1, true };
                yield return new object[] {6, false };
            }
        }

        // This can be used to get data from database, web service ect.. esp for intergration tests
        public static IEnumerable<object[]> IsOddOrEvenDataExternalData
        {
            get
            {
                var allLines = System.IO.File.ReadAllLines("IsOddOrEvenTestData.txt");
                return allLines.Select(
                    x =>
                    {
                        var lineSplit = x.Split(',');
                        return new object[] { int.Parse(lineSplit[0]), bool.Parse(lineSplit[1]) };
                    });
            }
        }
    }
}

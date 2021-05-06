using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Customer
    {
        public string Name => "Joe";
        public int Age => 37;

        public int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Hello Bad Mistake");
            }

            return 100;
        }
    }
}

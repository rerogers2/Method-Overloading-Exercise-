using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        
        public static decimal add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string add(int a, int b, Boolean c)
        {
            var sum = a + b;
            if (c == true && sum != 1)
            {
                return $"{a + b} dollars";
            }
            else if (c == true && sum == 1)
            {
                return $"{a + b} dollar";
            }
            else
            {
                return $"The sum is {sum.ToString()} but it's not dollars";
            }
        }
    }
}

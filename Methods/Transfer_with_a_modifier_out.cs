using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer_with_a_modifier_out
{
    class Transfer_with_a_modifier_out
    {
        static void GetValues(out int x, out int y)
        {
            x = 6;
            y = 42;
        }
        static void Main(string[] args)
        {
            int a, b;
            GetValues(out a, out b);
            Console.WriteLine(a+" "+b); // a = 6, b = 42
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperators
{
    class IncDec
    {
        static void Main(string[] args)
        {
         int a_pref = 5;
         int a_post = 5;
         int b_pref = 5;
         int b_post = 5;
         int b_1 = 6, b_2 = 6;
         int a_1 = 6, a_2 = 6;
         b_1 = ++a_pref;
         b_2 = a_post++;
         a_1 = --b_pref;
         a_2 = b_post--;
         Console.WriteLine("Result: {0} {1}", b_1, a_pref); // b_1 = 6 a_pref = 6
         Console.WriteLine("Result: {0} {1}", b_2, a_post); // b_2 = 5 a_post = 6
         Console.WriteLine("Result: {0} {1}", a_1, b_pref); // a_1 = 4 b_pref = 4
         Console.WriteLine("Result: {0} {1}", a_2, b_post); // a_2 = 5 b_post = 4
        }
    }
}

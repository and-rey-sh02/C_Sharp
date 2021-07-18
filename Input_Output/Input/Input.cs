using System;
using System.Collections.Generic;

namespace Input
{
    class Input
    {
        static void Main(string[] args)
        {
         int i_num1, i_nam2;
         Console.WriteLine("Enter the first number");
         i_num1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter the second number");
         i_nam2 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Result:" + (i_num1 + i_nam2).ToString());
         Console.ReadKey();
        }
    }
}

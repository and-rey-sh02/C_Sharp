using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Void
{
    class Method_Void
    {
        static void Add(int num_1, int num_2)
        {
         Console.WriteLine("Result = " + (num_1 + num_2).ToString());
        }
        static void Main(string[] args)
        {
         Console.WriteLine("Enter two numbers ");
         int n_1 = Convert.ToInt32(Console.ReadLine());
         int n_2 = Convert.ToInt32(Console.ReadLine());
         Add(n_1, n_2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_with_type
{
    class Method_with_type
    {
    static int Add(int num_1, int num_2)
    {
     return num_1 + num_2;
    }
        static void Main(string[] args)
        {
         Console.WriteLine("Enter two numbers ");
         int n_1 = Convert.ToInt32(Console.ReadLine());
         int n_2 = Convert.ToInt32(Console.ReadLine());
         int result = Add(n_1, n_2);
         Console.WriteLine("Result = " + result);
         Console.WriteLine("Result = " + Add(n_1, n_2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_condition
{
    class nested_condition
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Enter two numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a >= b)
            {
                Console.WriteLine("{0} >= {1}", a, b);
                if (a == b)
                {
                    Console.WriteLine("{0} = {1}", a, b);
                }
            }
            else
             {
              Console.WriteLine("{0} > {1}", b, a);
             }
        }
    }
}

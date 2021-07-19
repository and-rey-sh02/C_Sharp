using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading
{
    class Method_overloading
    {
        class Some
        {
            public void Multiply(int a, int b)
            {
                Console.WriteLine("Result is " + a * b);
            }
            public void Multiply(int a, int b, int c)
            {
                Console.WriteLine("Result is " + a * b * c);
            }
            public void Multiply(string str)
            {
                Console.WriteLine("Result is " + str);
            }

        }
        static void Main(string[] args)
        {
            Some test = new Some();
            test.Multiply(2, 23);
            test.Multiply(2, 23, 4);
            test.Multiply("Some test");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalized_method
{
    class Generalized_method
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 4, b = 9;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a+" "+b);

            string x = "Hello";
            string y = "Word";
            Swap<string>(ref x, ref y);
            Console.WriteLine(x+" "+y);
        }
    }
}

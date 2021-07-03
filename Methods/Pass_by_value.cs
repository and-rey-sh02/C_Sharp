using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_by_value
{
    class Pass_by_value
    {
        static void Sqr(int x)
        {
            x = x * x;
        }
        static void Main(string[] args)
        {
            int a = 3;
            Sqr(a);
            Console.WriteLine(a); //3
        }
    }
}

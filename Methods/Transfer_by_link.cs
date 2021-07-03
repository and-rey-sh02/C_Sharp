using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer_by_link
{
    class Transfer_by_link
    {
        static void Sqr(ref int x)
        {
            x = x * x; 
        }
        static void Main(string[] args)
        {
            int a = 3;
            Sqr(ref a);
            Console.WriteLine(a); //9
        }
    }
}

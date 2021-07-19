using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_arguments
{
    class Optional_arguments
    {
        static int Pow(int x, int y = 2)
        {
            int result = 1;
            for(int i = 0; i < y; i++)
            {
                result *= x; 
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Pow(6)); //6^2
            Console.WriteLine(Pow(3, 4)); //3^4
        }
    }
}

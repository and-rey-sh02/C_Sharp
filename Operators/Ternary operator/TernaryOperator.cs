using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else
{
    class If_else
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Enter two numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            string c = a == b
             ? "The numbers are equal"
             : "The numbers are not equal";
            Console.WriteLine(c);
        }
    }
}

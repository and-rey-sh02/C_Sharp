using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else_if
{
    class If_else_if
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Enter number: ");
            a = Convert.ToInt32(Console.ReadLine());    
            if (a <= 50)
             {
              Console.WriteLine("{0} <= 50", a);  
             }
            else if (a < 99)
             {
              Console.WriteLine("{0} < 99", a);
             }
            else if (a == 100)
             {
              Console.WriteLine("{0} = 100", a);
             }
            else
            {
             Console.WriteLine("Not in range");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Switch
    {
        static void Main(string[] args)
        {
         int a;
         Console.WriteLine("Enter a number from 1 to 5: ");
         a = Convert.ToInt32(Console.ReadLine());
         switch(a)
          {
           case 1 : Console.WriteLine("{0} = 1",a);
            break;
           case 2 : Console.WriteLine("{0} = 2", a);
            break;
           case 3 : Console.WriteLine("{0} = 3", a);
            break;
           case 4 : Console.WriteLine("{0} = 4", a);
            break;
           case 5 : Console.WriteLine("{0} = 5", a);
            break;
           default : Console.WriteLine("Error entered 0");
            break;
            }
        }
    }
}

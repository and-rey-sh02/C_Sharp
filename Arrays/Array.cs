using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
         int[] mass = new int[10];
         Random rand = new Random();
          for (int i = 0; i < mass.Length; i++)
           {
            mass[i] = rand.Next(10);
            Console.WriteLine("{0} \n", mass[i]);
           }
        }
    }
}

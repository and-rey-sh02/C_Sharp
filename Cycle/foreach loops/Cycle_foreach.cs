using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
         int[] mass = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
          foreach(int el in mass)
          {
           Console.WriteLine(el);
          }
        }
    }
}

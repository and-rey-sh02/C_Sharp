using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        static void Main(string[] args)
        {
         Random rnd = new Random();
         int[,] arr = new int[5, 5];
          for(int i = 0; i < 5; i++)
          {
           for(int j = 0; j < 5; j++)
           {
            arr[i, j] = rnd.Next(0, 10);
            Console.Write(arr[i, j]+"\t");
           }
           Console.WriteLine("");
          }
        }
    }
}

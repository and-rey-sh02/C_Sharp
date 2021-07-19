using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitarray
{
    class Program
    {
        public static void PrintBarr(string name, BitArray ba)
        {
            Console.WriteLine(name + " : ");
            for (int x = 0; x < ba.Length; x++)
                Console.WriteLine(ba.Get(x) + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);

            ba1.SetAll(true);
            ba2.SetAll(false);

            ba1.Set(2, false);
            ba2.Set(3, true);

            PrintBarr("ba1", ba1);
            PrintBarr("ba2", ba2);

            PrintBarr("ba1 AND ba2", ba1.And(ba2));
            PrintBarr("Not ba2", ba2.Not());
        }
    }
}

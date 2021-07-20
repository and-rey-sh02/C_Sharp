using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class HashSet
    {
        static void Main(string[] args)
        {
            HashSet<int> hs1 = new HashSet<int>();
            hs1.Add(5);
            hs1.Add(10);
            hs1.Add(15);
            hs1.Add(20);
            Console.Write("\nHashSet: ");
            foreach (int i in hs1)
                Console.Write(i + " ");
            Console.Write("\nCount: " + hs1.Count);
            HashSet<int> hs2 = new HashSet<int>();
            hs2.Add(15);
            hs2.Add(20);
            Console.Write("\n{15, 20} is a subset of {5, 10, 15, 20}: " + hs2.IsSubsetOf(hs1));
        }
    }
}

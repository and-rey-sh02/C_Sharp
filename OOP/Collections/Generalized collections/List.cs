using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(59);
            li.Add(72);
            li.Add(95);
            li.Add(5);
            li.Add(9);
            li.Remove(1);
            Console.WriteLine("\n List: ");
            for (int x = 0; x < li.Count; x++)
                Console.WriteLine(li[x] + " ");
            li.Sort();
            Console.WriteLine("\n Sorted: ");
            for (int x = 0; x < li.Count; x++)
                Console.WriteLine(li[x] + " ");
        }
    }
}

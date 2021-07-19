using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class SortedList
    {
        static void Main(string[] args)
        {
            SortedList<string, int> sl = new SortedList<string, int>();
            sl.Add("Solo", 59);
            sl.Add("A", 95);
            sl.Add("Learn", 72);
            sl.Remove("A");
            Console.WriteLine("Sorted List: ");
            foreach (string s in sl.Keys)
                Console.WriteLine(s + ": " + sl[s]);
            Console.WriteLine("\n Count: " + sl.Count);
        }
    }
}

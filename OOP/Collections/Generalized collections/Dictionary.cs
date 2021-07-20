using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("Uno", 1);
            d.Add("One", 1);
            d.Add("Dos", 2);
            d.Add("Deux", 2);
            d.Remove("One");
            d.Remove("Dos");
            Console.WriteLine("Dictionary: ");
            foreach(string s in d.Keys)
                Console.WriteLine(s + ": " + d[s]);
            Console.WriteLine("\nCount: {0}", d.Count);
        }
    }
}

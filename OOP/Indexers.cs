using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Indexers
    {
        class Client
        {
            private string[] names = new string[10];
            public string this[int index]
            {
                get
                {
                    return names[index];
                }
                set
                {
                    names[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Client c = new Client();
            c[0] = "Dave";
            c[1] = "Bob";
            Console.WriteLine(c[1]);
        }
    }
}

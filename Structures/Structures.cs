using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct Book
    {
        public string title;
        public string name;
        public string author;
    }
    class Structures
    {
        static void Main(string[] args)
        {
            Book b;
            b.title = "C#";
            b.name = "Andrey";
            b.author = "King";
            Console.WriteLine(b.title);
            Console.WriteLine(b.name);
            Console.WriteLine(b.author);
        }
    }
}

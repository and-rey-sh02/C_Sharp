using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Static
    {
        class Cat
        {
            public static int count = 0;
            public const int ONE = 1;
            public static string Name { get; set; } 
            public Cat()
            {
                count++;
            }
            public static void Vote()
            {
                Console.WriteLine("This is a cat");
            }
            static Cat()
            {
                Name = "Alex";
            }
        }
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            Cat c2 = new Cat();
            Console.WriteLine(Cat.count);
            Cat.Vote();
            Console.WriteLine(Cat.ONE);
            Console.WriteLine(Cat.Name);
        }
    }
}

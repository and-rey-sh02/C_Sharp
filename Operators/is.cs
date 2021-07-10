using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @is
{
    class Program
    {
        class Animal
        {
            public string name;
        }
        class Dog : Animal
        {
            private float speed;
        }
        class Cat : Animal
        {
            private float speed;
        }

        static void Main(string[] args)
        {
            Animal animals = new Animal();
            Dog Alex = new Dog();
            Cat Tom = new Cat();
            //true
            if (Alex is Animal)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            //true
            if (Tom is Animal)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            //false
            if (Alex is Cat)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}

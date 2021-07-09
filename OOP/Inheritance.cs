using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Inheritance
    { 
        class Animal
        { 
            public string Name { get; set; }
            public Animal(string name)
            {
                Name = name;
            }
            public void Print()
            {
                Console.WriteLine(Name);
            }
        }
        class Dog : Animal
        {
            private float speed;
            public Dog(float speed, string name) : base (name)
            {
                this.speed = speed;
                Console.WriteLine("Speed: " + speed);
            }
        }
        static void Main(string[] args)
        {
            Dog tom = new Dog(12.23f, "Tom");
            Console.WriteLine(tom.Name);
            Dog jerry = new Dog(23.2f, "Jerry");
            Console.WriteLine(jerry.Name);
            Console.WriteLine();
            jerry.Print();
        }
    }
}

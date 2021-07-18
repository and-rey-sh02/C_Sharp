using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @as
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
            //false
            Alex = animals as Dog;
            if(Alex == null)
            {
                Console.WriteLine("Impossible to lead");
            }
            else
            {
                Console.WriteLine("You can bring");
            }
            //true
            animals = Tom as Animal;
            if(animals == null)
            {
                Console.WriteLine("Impossible to lead");
            }
            else
            {
                Console.WriteLine("You can bring");
            }
            //using is operator
            if (Tom is Animal)
                animals = (Animal)Tom;
            else
                animals = null;
            if (animals == null)
            {
                Console.WriteLine("Impossible to lead");
            }
            else
            {
                Console.WriteLine("You can bring");
            }
        }
    }
}

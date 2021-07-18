using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_pointers
{
    class Array_of_pointers
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
            public Dog(float speed, string name) : base(name)
            {
                this.speed = speed;
            }
        }
        class Cat : Animal
        {
            private float speed;
            public Cat(float speed, string name) : base(name)
            {
                this.speed = speed;
            }
        }
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(12.23f, "Alex"));
            animals.Add(new Dog(12.3f, "Tom"));
            animals.Add(new Cat(12.3f, "Sam"));
            foreach (Animal animal in animals)
            {
               if (animal is Animal)
                Console.WriteLine(animal.Name);
               if (animal is Cat)
                 (animal as Cat).Print();
            }
        }
    }
}

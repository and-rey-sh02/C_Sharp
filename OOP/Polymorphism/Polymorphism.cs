using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Polymorphism
    {
        class Animal
        {
            public string Name { get; set; }
            public Animal(string name)
            {
                Name = name;
            }
            public virtual void Print()
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
            public override void Print()
            {
                base.Print();
                Console.WriteLine("Dog speed: " + speed);
            }
        }
        class Cat : Animal
        {
            private float speed;
            public Cat(float speed, string name) : base(name)
            {
                this.speed = speed;
            }
            public override void Print()
            {
                base.Print();
                Console.WriteLine("Cat speed: " + speed);
            }
        }
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(12.23f, "Alex"));
            animals.Add(new Dog(12.3f, "Tom"));
            animals.Add(new Cat(14.3f, "Sam"));
            foreach (Animal animal in animals)
            {
                animal.Print();
            }
        }
    }
}

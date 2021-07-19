using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @this
{
    class Program
    {
        class Animal
        {
            public static int count;
            public string name;
            public int age;
            public float hapiness;
            public Animal()
            {
                name = "Spotty";
                age = 7;
                hapiness = 0.6f;
                count++;
                Print();
            }
            public Animal(string name, int age, float hapiness)
            {
                this.name = name;
                this.age = age;
                this.hapiness = hapiness;
                count++;
                Print();
            }
            public void Print()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("hapiness " + hapiness);
            }
        }
        class Class
        {
            static void Main(string[] args)
            {
                Animal cat = new Animal();
                Console.WriteLine();
                Animal dog = new Animal("Tom", 12, 0.99f);
                Console.WriteLine();
                Console.WriteLine("Count of animals: " + Animal.count);
            }
        }
    }
}

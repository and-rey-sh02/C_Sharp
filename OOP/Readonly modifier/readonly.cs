using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @readonly
{
    class Program
    {
        class Person
        {
            public readonly string name = "John";
            public Person(string name)
            {
                this.name = name;
            }
            public Person()
            {             
            }
            public void Print()
            {
                Console.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new Person("Andrey");
            p1.Print();
            Person p2 = new Person();
            p2.Print();
        }
    }
}

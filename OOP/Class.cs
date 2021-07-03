using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Animal
    {
        public string name = "Spotty";
        public int age = 7;
        public float hapiness = 0.6f;
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
            cat.Print();
        }
    }
}

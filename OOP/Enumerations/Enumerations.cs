using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    enum Bread { Dog, Cat, Bird, Bear, Tiger};
    class Enumerations
    {
        class Animal
        {
            public Bread bread;
            public Animal(Bread bread)
            {
                this.bread = bread;
            }
            public void Print()
            {
                Console.WriteLine(bread);
            }
        }
        static void Main(string[] args)
        {
            Animal an_1 = new Animal(Bread.Bird);
            an_1.Print();
            Animal an_2 = new Animal(Bread.Cat);
            an_2.Print();
            Animal an_3 = new Animal(Bread.Dog);
            an_3.Print();
        }
    }
}

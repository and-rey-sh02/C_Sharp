using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Classes
{
    class Nested_Classes
    {
        class Car
        {
            string name;
            public Car(string _name)
            {
                name = _name;
                Console.WriteLine("Class Car");
                Motor m = new Motor(5);
            }
            public class Motor
            {
                int volume;
                public Motor(int _volume)
                {
                    volume = _volume;
                    Console.WriteLine("Class Motor");
                }
            }
        }
        static void Main(string[] args)
        {
            Car c = new Car("Class Car");
        }
    }
}

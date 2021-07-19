using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Interfaces
    {
        interface ISomeInterface
        {
            int property { get; set; }
            void Print(); 
        }
        interface IDraw
        {
            void Draw();
        }
        class Test_1 : ISomeInterface, IDraw
        {
            public int property { get; set; }
            public void Print()
            {
                Console.WriteLine("Some text_1");
            }
            public void Draw()
            {
                Console.WriteLine("Draw method");
            }
        }
        class Test_2 : ISomeInterface
        {
            public int property { get; set; }
            public void Print()
            {
                Console.WriteLine("This is text_2");
            }
        }
        static void Main(string[] args)
        {
            Test_1 test_1 = new Test_1();
            Test_2 test_2 = new Test_2();
            test_1.property = 12;
            test_1.Print();
            Console.WriteLine(test_1.property);
            test_1.Draw();
            Console.WriteLine();
            test_2.property = 15;
            test_2.Print();
            Console.WriteLine(test_2.property);
        }
    }
}

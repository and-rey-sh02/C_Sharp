using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_and_Set_accessors
{
    class Get_and_Set_accessors
    {
        class Student
        {
            private int course;
            private string name;
            private bool stip;
            public int Course
            {
                get
                {
                    return course;
                }
                set
                {
                    if (value < 1)
                        course = 1;
                    else if (value > 5)
                        course = 5;
                    else
                        course = value;
                }
            }
            public string Name { get; set; }
            public Student()
            {
                course = 3;
                name = "Andrey";
                stip = true;
            }
            public void Print()
            {
                Console.WriteLine("Course " + course);
                Console.WriteLine("Name " + name);
                if (stip == true)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
        }
        static void Main(string[] args)
        {  
            Student p_1 = new Student();
            p_1.Print();
            p_1.Course = 4;
            p_1.Name = "Alex";
            Console.WriteLine(p_1.Course);
            Console.WriteLine(p_1.Name);
        }
    }
}


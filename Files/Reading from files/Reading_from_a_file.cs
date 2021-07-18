using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reading_from_a_file
{
    class Reading_from_a_file
    {
        static void Main(string[] args)
        {
            string str = "Some text";
            File.WriteAllText("test.txt", str);
            string txt = File.ReadAllText("test.txt");
            Console.WriteLine(txt);
        }
    }
}

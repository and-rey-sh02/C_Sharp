using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Write_to_file
{
    class Write_to_file
    {
        static void Main(string[] args)
        {
            string str = "Some text";
            File.WriteAllText("test.txt", str);
        }
    }
}

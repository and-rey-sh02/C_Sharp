using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_arguments
{
    class Named_arguments
    {
        static int Area(int h, int w)
        {
            return h * w;
        }
        static void Main(string[] args)
        {
            int res = Area(w: 5, h: 8);
            Console.WriteLine(res);
        }
    }
}

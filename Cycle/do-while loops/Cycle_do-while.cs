﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
         int i = 0;
            do {
                Console.WriteLine($"{i} \n");
                i++;
               } while (i < 10);
        }
    }
}

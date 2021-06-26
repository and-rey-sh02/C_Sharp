using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Str_func_1
{
    class Str_func_1
    {
        static void Main(string[] args)
        {
         string str_1 = "Hello";
         string str_2 = "";
         string str_3 = "\t";
         string str_4 = "HellO WorLD";
         string str_5 = "C, C++, C#";
         char[] sym = str_4.ToCharArray();
         string[] prog = str_5.Split(',');
         Console.WriteLine(sym[4]); // O
         Console.WriteLine(prog[1]); // C++
         Console.WriteLine(str_1[1]); // e
         Console.WriteLine(str_1.Length); // 5
         Console.WriteLine(String.IsNullOrEmpty(str_1)); // False
         Console.WriteLine(String.IsNullOrEmpty(str_2)); // True
         Console.WriteLine(String.IsNullOrWhiteSpace(str_3)); // True
         Console.WriteLine(String.Compare("a","b")); // -1
         Console.WriteLine(String.Compare("b", "a")); // 1
         Console.WriteLine(String.Compare("a", "a")); // 0
         Console.WriteLine(str_4.ToLower()); // hello world
         Console.WriteLine(str_4.ToUpper()); // HELLO WORLD
         Console.WriteLine(str_4.Contains("llO")); // True
         Console.WriteLine(str_4.StartsWith("Hell")); // True
         Console.WriteLine(str_4.EndsWith("LD")); // True
         Console.WriteLine(str_4.Insert(5,"LD")); // HellOLD WorLD
         Console.WriteLine(str_4.Remove(5)); // HellO
         Console.WriteLine(str_4.Replace("llO","llo")); // Hello WorLD

        }
    }
}

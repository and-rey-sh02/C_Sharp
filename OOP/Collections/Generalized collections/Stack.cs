using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(59);
            s.Push(72);
            s.Push(65);
            Console.Write("Stack: ");
            foreach (int i in s)
                Console.Write(i + " ");
            Console.Write("\nCount: " + s.Count);
            Console.Write("\nTop: " + s.Peek());
            Console.Write("\nPop: " + s.Pop());
            Console.Write("\nStack: ");
            foreach (int i in s)
                Console.Write(i + " ");
            Console.Write("\nCount: " + s.Count);
        }
    }
}

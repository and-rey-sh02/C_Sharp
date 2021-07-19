using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(5);
            q.Enqueue(10);
            q.Enqueue(15);
            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");
            Console.Write("\nCount: " + q.Count);
            Console.Write("\nDequeue: " + q.Dequeue());
            Console.Write("\nQueue:");
            foreach (int i in q)
                Console.Write(i + " ");
            Console.Write("\nCount: " + q.Count);
        }
    }
}

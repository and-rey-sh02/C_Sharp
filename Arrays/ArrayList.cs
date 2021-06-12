using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class ArrayList
    {
        static void Main(string[] args)
        {
         List<int> arr = new List<int>();
         arr.Add(0);
         arr.Add(1);
         arr.Add(2);
         arr.Add(3);
         arr.Add(4);
         arr.Add(5);
            for (int i = 0; i < arr.Count; i++)
             Console.WriteLine("{0} \n", arr[i]);
        }
    }
}

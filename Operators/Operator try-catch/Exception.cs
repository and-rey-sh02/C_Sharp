using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[] { 4, 5, 8 };
                Console.WriteLine(arr[8]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Num is " + num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception");
            }
            finally
            {
                Console.WriteLine("Program completed");
            }
        }
    }
}

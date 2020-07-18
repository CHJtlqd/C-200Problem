using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Overflow & checked keyword
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // y = int.MaxValue + 10;   // compile error
            int x = int.MaxValue, y = 0;

            checked
            {
                try
                {
                    y = x + 10;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.MaxValue + 10 = {0}", y);
        }
    }
}

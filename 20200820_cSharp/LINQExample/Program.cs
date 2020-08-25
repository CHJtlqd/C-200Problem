using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    class Program
    {
        static void Print(List<int> aList)
        {
            foreach (var num in aList)
            {
                Console.WriteLine($"{num}");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<int> aList1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> aList2 = new List<int>();

            
            aList2 = (from Temp in aList1 select Temp).ToList<int>();
            Print(aList2);

        }

        static void Main1(string[] args)
        {
            List<int> aList1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> aList2 = new List<int>();

            foreach (var Temp in aList1)
            {
                aList2.Add(Temp);
            }

            Print(aList1);
            Print(aList1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FormatSpecifier
namespace _1_11
{
    // # : Digit placeholder(0이 앞에 붙지 않음)
    // 0 : Zero placeholder(0이 앞에 붙음)
    // . : 소숫점(Decimal point)
    // , : 천 자리(Thousands operator)
    // ; :  섹션 구분 기호(Section separator)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:N2}", 1234.5678); // 1,234.57
            Console.WriteLine("{0:D8}", 1234);      // 00001234
            Console.WriteLine("{0:F3}", 1234.56);   // 1234.500
            Console.WriteLine("{0,8}", 1234);       // ____1234
            Console.WriteLine("{0,-8}", 1234);      // 1234____

            Console.WriteLine(1234.5678.ToString("N2"));
            Console.WriteLine(1234.ToString("D8"));
            Console.WriteLine(1234.56.ToString("F3"));

            Console.WriteLine("{0:#.##}", 1234.5678);
            Console.WriteLine("{0:0,0.00}", 1234.5678);
            Console.WriteLine("{0:#,#.##}", 1234.5678);
            Console.WriteLine("{0:000000.00}", 1234.5678);

            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 1234.567);
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", -1234.567);
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 0);
        }
    }
}

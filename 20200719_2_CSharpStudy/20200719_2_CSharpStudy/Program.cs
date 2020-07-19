using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ConstAndReadOnly
namespace _20200719_2_CSharpStudy
{
    // const : 선언될 때 값이 할당, 컴파일 시에 값이 결정
    // readonly : 실행될 때 또는 객체가 생성자에 의해 초기화될 때 할당, 런타임 시에 값이 결정

    class ConstEx
    {
        public const int number = 3;
    }

    class ReadonlyEx
    {
        public readonly int number = 10;
        public ReadonlyEx()
        {
            number = 20;
        }

        public ReadonlyEx(int n)
        {
            number = n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConstEx.number);

            ReadonlyEx inst1 = new ReadonlyEx();
            Console.WriteLine(inst1.number);

            ReadonlyEx inst2 = new ReadonlyEx(100);
            Console.WriteLine(inst2.number);
        }
    }
}

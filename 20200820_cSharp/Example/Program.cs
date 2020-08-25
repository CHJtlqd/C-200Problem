using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Fact : IComparable
    {
        public string name;
        public int age;
        public string gender;

        public int CompareTo(object obj)
        {
            return age.CompareTo(((Fact)obj).age);
        }

        public override string ToString()
        {
            return string.Format($"[{name}, {age}, {gender}]");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Fact> aList = new List<Fact>();
            Fact Temp = new Fact();
            Temp.name = "그놈";
            Temp.age = 20;
            Temp.gender = "남";
            aList.Add(Temp);

            Temp = new Fact();
            Temp.name = "그녀";
            Temp.age = 19;
            Temp.gender = "여";
            aList.Add(Temp);

            Temp = new Fact();
            Temp.name = "그녀";
            Temp.age = 33;
            Temp.gender = "여";
            aList.Add(Temp);

            Temp = new Fact();
            Temp.name = "그녀";
            Temp.age = 28;
            Temp.gender = "여";
            aList.Add(Temp);

            Temp = new Fact();
            Temp.name = "그녀";
            Temp.age = 99;
            Temp.gender = "여";
            aList.Add(Temp);

            aList.Sort();

            foreach (var item in aList)
            {
                Console.WriteLine(item);
            }


        }
    }
}

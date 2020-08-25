using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(object obj)
        {
            Product temp = obj as Product;
            return temp.Price.CompareTo(this.Price);
            //return this.Price.CompareTo(temp.Name);
        }

        public override string ToString()
        {
            return Name + ":" + Price + "원" + "\n";
        }
    }
}

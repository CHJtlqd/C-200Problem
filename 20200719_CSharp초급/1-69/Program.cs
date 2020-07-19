using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Property
namespace _1_69
{
    class Rectangle
    {
        private double width;
        private double height;

        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetWidth(double width)
        {
            if (width > 0)
                this.width = width;
        }

        public void SetHeight(double height)
        {
            if (height > 0)
                this.height = height;
        }

    }

    class RectWithProp
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    class RectWithPropFull
    {
        private double width;

        public double Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
            }
        }




    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.SetHeight(10.0);
            r.SetHeight(10.0);
            Console.WriteLine("r의 면적은 {0}", r.GetWidth() * r.GetHeight());


        }
    }
}

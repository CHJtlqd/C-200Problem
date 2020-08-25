using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> aList = new List<Product>() {
               
                new Product(){ Name="고메", Price=1000},
                new Product(){ Name="군고메", Price=2000},
                new Product(){ Name="찐고메", Price=200},
                new Product(){ Name="짠고메", Price=500},
                new Product(){ Name="단고메", Price=3000},
            };

            aList.Sort((x,y)=> {
                return x.Price.CompareTo(y.Price);
            });
            string result = "";
            foreach (var Temp in aList)
            {
                result += Temp+"\n";
            }

            MessageBox.Show(result);
        }
    }
}

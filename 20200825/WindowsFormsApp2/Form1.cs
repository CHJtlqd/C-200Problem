using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StreamReader R = new StreamReader(@"c:\factory.txt");
            while (true) {
                string rName = R.ReadLine();
                if (null == rName) {
                    break;
                }
                string rPrice = R.ReadLine();
                productBindingSource.Add(new Product() { Name = rName, Price = Convert.ToInt32(rPrice) });
            }
            //productBindingSource.Add(new Product() { Name = "고메", Price = 1000 });
            //productBindingSource.Add(new Product() { Name = "군고메", Price = 2000 });
            //productBindingSource.Add(new Product() { Name = "찐고메", Price = 200 });
            //productBindingSource.Add(new Product() { Name = "짠고메", Price = 500 });
            //productBindingSource.Add(new Product() { Name = "단고메", Price = 3000 });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.StackTrace);
            }
        }

        private void button1_Click2(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader(@"c:\factory.txt");

            string readResult;
            while (true)
            {
                readResult = r.ReadLine();
                if (null == readResult)
                    break;
                MessageBox.Show(readResult);
            }
        }

        private void button1_Click1(object sender, EventArgs e)
        {
            //File.WriteAllText("C:\\factory.txt","Factory");   //write
            //MessageBox.Show(File.ReadAllText("c:\\factory.txt")); //read
            StreamWriter w = new StreamWriter(@"c:\factory.txt");
            w.WriteLine("지옥으로키티");
            w.WriteLine("디다려 키티");
            w.Close();
        }
    }
}

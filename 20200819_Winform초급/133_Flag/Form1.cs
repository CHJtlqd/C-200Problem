﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _133_Flag
{
    public partial class Form1 : Form
    {
        private bool flag; // 디폴트는 false
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                label1.Text = "Hello World!";
                flag = true;
            }
            else
            {
                label1.Text = "";
                flag = false;
            }
        }
    }
}

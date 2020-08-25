using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _139_RgbScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.LightSteelBlue;
            panel1.BackColor = Color.FromArgb(0, 0, 0);
            txtRed.Text = 0.ToString();
            txtGreen.Text = 0.ToString();
            txtBlue.Text = 0.ToString();
            scRed.Maximum = 255 + 9;
            scGreen.Maximum = 255 + 9;
            scBlue.Maximum = 255 + 9;
        }

        private void scr_Scroll(object sender, ScrollEventArgs e)
        {
            txtRed.Text = scRed.Value.ToString();
            txtGreen.Text = scGreen.Value.ToString();
            txtBlue.Text = scBlue.Value.ToString();

            panel1.BackColor = Color.FromArgb(scRed.Value, scGreen.Value, scBlue.Value);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (txtRed.Text != "" && txtGreen.Text != "" && txtBlue.Text != "")
            {
                scRed.Value = int.Parse(txtRed.Text);
                scGreen.Value = int.Parse(txtGreen.Text);
                scBlue.Value = int.Parse(txtBlue.Text);
                panel1.BackColor = Color.FromArgb(scRed.Value, scGreen.Value, scBlue.Value);
            }
        }
    }
}

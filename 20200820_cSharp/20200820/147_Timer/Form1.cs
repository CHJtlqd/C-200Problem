using System;
using System.Windows.Forms;

namespace _147_Timer
{
    public partial class Form1 : Form
    {
        private int CountMS = 0, CountS = 0, CountM = 0;
        private bool Toggle = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DispM.Text = CountM.ToString();
            DispS.Text = CountS.ToString();
            DispMS.Text = CountMS.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (false == Toggle)
            {
                timer1.Start();
                timer2.Start();
                Toggle = true;
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                Toggle = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Location = new Point(ClientSize.Width / 2 - label1.Width / 2,
            //    ClientSize.Height / 2 - label1.Height / 2);
            //label1.Font = new Font("맑은 고딕", 30, FontStyle.Bold);
            //label1.Text = DateTime.Now.ToString();
            //DispM.Text = DateTime.Now.Minute.ToString();
            //DispS.Text = DateTime.Now.Second.ToString();
            //DispMS.Text = DateTime.Now.Millisecond.ToString();

            ++CountMS;
            if (CountMS == 60)
            {
                CountMS = 0;
                ++CountS;
                if (CountS == 60)
                {
                    CountS = 0;
                    ++CountM;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

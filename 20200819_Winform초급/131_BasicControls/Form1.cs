using System;
using System.Windows.Forms;

namespace _131_BasicControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 텍스트박스에 이름을 입력하지 않았을 때
            if (textBox1.Text == "")
            {
                label2.Text = "";
                MessageBox.Show("이름을 입력하세요", "경고");
            }
            else
            {
                label2.Text = textBox1.Text+"님! 안녕하세요!";
            }
        }
    }
}

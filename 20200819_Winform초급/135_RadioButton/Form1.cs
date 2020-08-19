using System;
using System.Windows.Forms;

namespace _135_RadioButton
{
    public partial class Form1 : Form
    {
        private RadioButton checkedRB;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "국적: ";
            foreach (RadioButton item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    result += item.Text + "\n";
                    break;
                }
            }
            foreach (RadioButton item in groupBox2.Controls)
            {
                if (item.Checked)
                {
                    result += "성별: " + item.Text;
                    break;
                }
            }
            //if (rbKorea.Checked)
            //    result += "국적: 대한민국\n";
            //else if(rbChina.Checked)
            //    result += "국적: 중국\n";
            //else if (rbJapan.Checked)
            //    result += "국적: 일본\n";
            //else if (rbOthers.Checked)
            //    result += "국적: 그 외 국가\n";

            //if (checkedRB == rbMale)
            //    result += "성별: 남성";
            //else if (checkedRB == rbFemale)
            //    result += "성별: 여성";

            MessageBox.Show(result, "Result");
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = rbMale;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = rbFemale;

        }
    }
}

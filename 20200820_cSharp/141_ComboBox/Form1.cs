using System;
using System.Windows.Forms;

namespace _141_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            factBindingSource.Add(new Fact("그놈1", 20, "남"));
            factBindingSource.Add(new Fact("그놈2", 22, "남"));
            factBindingSource.Add(new Fact("그놈3", 23, "남"));
            factBindingSource.Add(new Fact("그놈4", 24, "남"));
            factBindingSource.Add(new Fact("그놈5", 21, "남"));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox cb = sender as ComboBox;
            //lblRestaurant.Text = "이번 주 모임장소는: " + cb.SelectedItem.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (comboBox1.Text != "")
            //{
            //    comboBox1.Items.Add(comboBox1.Text);
            //    lblRestaurant.Text = comboBox1.Text + " Added!";
            //}
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedIndex >= 0)
            //{
            //    lblRestaurant.Text = comboBox1.SelectedItem.ToString() + " Deleted";
            //    comboBox1.Items.Remove(comboBox1.SelectedItem);
            //}
        }
    }
}

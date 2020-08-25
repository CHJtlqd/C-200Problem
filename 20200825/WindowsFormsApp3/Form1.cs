using System.Windows.Forms;
using SharpPcap;
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //MessageBox.Show(SharpPcap.Version.VersionString);
            //CaptureDeviceList NicList = CaptureDeviceList.Instance;
            //string NicListResult = "";
            //foreach (var Temp in NicList)
            //{
            //    //string Temp2 = Temp.ToString().Substring(Temp.ToString().IndexOf("FriendlyName") + "FriendlyName".Length, 10);
            //    string[] arrTemp = Temp.ToString().Split('\n');
            //    string Temp2 = arrTemp[1].Substring("FriendlyName:".Length);
            //    NicListResult += Temp2 + "\n";
            //}

            //MessageBox.Show(NicListResult);
            Button[] btnList = new Button[4] {
                new Button(){Text = "button2",Name="button2"},
                new Button(){Text = "button3",Name="button3",Location=new System.Drawing.Point(0,30)},
                new Button(){Text = "button4",Name="button4",Location=new System.Drawing.Point(0,60)},
                new Button(){Text = "button5",Name="button5",Location=new System.Drawing.Point(0,90)},
            };

            foreach (var item in btnList)
            {
                Controls.Add(item);
            }
        }
    }
}

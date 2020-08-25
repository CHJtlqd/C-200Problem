using System;
using System.Windows.Forms;

namespace 숫자야구
{
    public partial class Form1 : Form
    {
        private int gameCount = 0;
        private int[] answer;
        private Random r = new Random();
        private bool[] check;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startGame();
        }

        private void startGame()
        {
            check = new bool[10];
            answer = new int[3];
            int cnt = 0;
            while (cnt < 3)
            {
                int temp = r.Next(10);
                if (!check[temp])
                {
                    check[temp] = true;
                    answer[cnt] = temp;
                    cnt++;
                }
            }
            gameCount = 0;
            strike.Text = "0";
            ball.Text = "0";
            count.Text = gameCount.ToString();
            listBox1.Items.Clear();
            textBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comp = textBox1.Text;
            string answerStr = answer[0].ToString() + answer[1].ToString() + answer[2].ToString();
            int strikeCnt = 0, ballCnt = 0;
            gameCount++;
            for (int i = 0; i < 3; i++)
            {
                if (comp[i] == answerStr[i])
                {
                    strikeCnt++;
                }
                else if (answerStr.Contains(comp[i].ToString()))
                {
                    ballCnt++;
                }
            }
            if (strikeCnt == 3)
            {
                MessageBox.Show("승리하셨습니다.");
                startGame();
                return;
            }
            if (strikeCnt == 0 && ballCnt == 0)
            {
                listBox1.Items.Add(comp + " = " + "OUT");
            }
            else
            {
                listBox1.Items.Add(comp + " = " + "S : " + strikeCnt + " B : " + ballCnt);
            }
            strike.Text = strikeCnt.ToString();
            ball.Text = ballCnt.ToString();
            count.Text = gameCount.ToString();
            textBox1.Text = "";
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            string str = answer[0].ToString() + answer[1].ToString() + answer[2].ToString();
            MessageBox.Show(str, "정답");
            startGame();
        }
    }
}

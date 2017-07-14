using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ArithmeticTest
{
    public partial class Form1 : Form
    {
        int a, b;
        int answer;
        int op, degree = 10;
        string[] sop = { "＋", "－", "×", "÷" };
        int countdown = 10; //倒计时
        Boolean sj; //随机标志

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startTest();
            btnStart.Text = "下一题";
        }

        private void startTest()
        {
            a = rnd.Next(degree);
            b = rnd.Next(degree);
            op = sj ? rnd.Next(4) : op;//随机

            switch (op)
            {
                case 0:
                    answer = a + b;
                    break;

                case 1:
                    answer = a - b;
                    break;

                case 2:
                    answer = a * b;
                    break;

                case 3:
                    answer = a / b;
                    break;
            }

            labQuestion.Text = string.Format("{0} {1} {2} =", a, sop[op], b);
            labCountdown.Text = countdown.ToString();
            txbAnswer.Text = "";
            txbAnswer.BackColor = Color.White;
            txbAnswer.Focus();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labCountdown.Text = (Convert.ToInt16(labCountdown.Text)-1).ToString();
            if (labCountdown.Text == "0")
            {
                checkAnswer();
                txbAnswer.Text = answer.ToString(); //show answer
                timer1.Stop();
            }
        }

        private void txbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txbAnswer.BackColor == Color.LightGreen)
                {
                    startTest();
                }
                else
                {
                    checkAnswer();
                }
            }
        }

        private void checkAnswer()
        {
            if (txbAnswer.Text.Trim() == answer.ToString())
            {
                txbAnswer.BackColor = Color.LightGreen;
            }
            else
            {
                txbAnswer.BackColor = Color.Red;
            }
            txbAnswer.SelectAll();
            txbAnswer.Focus();
        }

        private void rdbType_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
                return;

            sj = false;

            switch (((RadioButton)sender).Text)
            {
                case "加法":
                    op = 0; 
                    break;

                case "减法":
                    op = 1;
                    break;

                case "随机":
                    sj = true;
                    break;

                default:
                    break;
            }
        }

        private void rdbDegree_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
                return;

            switch (((RadioButton)sender).Text)
            {
                case "简单": //10以内
                    degree = 10;
                    countdown = 10; //5s
                    break;

                case "一般": //100以内
                    degree = 100;
                    countdown = 15;
                    break;

                case "复杂": //1000以内
                    degree = 1000;
                    countdown = 20;
                    break;
            }
        }
    }
}

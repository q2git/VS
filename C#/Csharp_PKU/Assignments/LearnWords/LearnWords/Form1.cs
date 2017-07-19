using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System;
using System.Text;

namespace 背单词程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadFile();
        }

        List<string> english = new List<string>();
        List<string> chinese = new List<string>();
        Random rnd = new Random();
        int count = 0;

        void ReadFile()
        {
            StreamReader dic = new StreamReader("College_Grade4.txt", Encoding.Default);
            string content = dic.ReadToEnd();
            string[] lines = content.Split('\n');

            for (int i = 0; i<lines.Length; i++)
            {
                string[] words = lines[i].Trim().Split('\t');
                if (words.Length < 2) continue;
                english.Add(words[0]);
                chinese.Add(words[1]);
            }
            count = english.Count;
        }

        void ShowWords()
        {
            int i = rnd.Next(count);
            lbEnglish.Text = english[i];
            lbChinese.Text = chinese[i];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowWords();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }
    }
}

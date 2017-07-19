using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.IO;
using System.Text;
using System;

//对输入框中输入的身份证是否合法进行验证
//一是使用正则表达式对格式进行验证（共18位，前17位是数字，最后1位是数字或字母X）
//二是对身份证的最后一位的有效性进行验证

namespace IDVerifier
{
    public partial class Form1 : Form
    {

        string[] pats = {
                     @"^(\d{6})",                        //location code
                     "(19[1-9][1-9]|20[0,1][0-7])",      //year
                     "(0[1-9]|1[0-2])",                  //month
                     "([0-2][1-9]|10|3[0-1])",              //day
                     @"(\d{3})",                         //sequence code
                     @"(\d|x|X)$",                       //verification code
                };

        char[] checksum = { '1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2' };
        int[] coef = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2};

        string[,] idlocList;

        public Form1()
        {
            InitializeComponent();
            rtfInputbox.SelectionAlignment = HorizontalAlignment.Center;
            readList();
        }

        private void rtfInputbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            ((RichTextBox)sender).SelectAll();
        }

        private void choosePat(string id)
        {
            switch (id.Length)
            {
                case 6: //location code
                    verifyPat(id, 0, 6, 0);
                    labLoc.Text = findLocation(id);
                    break;

                case 10: //year
                    labYear.Text = "";
                    if (verifyPat(id, 6, 4, 1))
                        labYear.Text = id.Substring(6, 4);
                    break;

                case 12: //month
                    labMonth.Text = "";
                    if (verifyPat(id, 10, 2, 2))
                        labMonth.Text = id.Substring(10, 2);
                    break;

                case 14: //day
                    labDay.Text = "";
                    if (verifyPat(id, 12, 2, 3))
                        labDay.Text = id.Substring(12, 2);
                    break;

                case 17: //sequence code
                    verifyPat(id, 14, 3, 4);
                    break;

                case 18: //verification code
                    verifyPat(id, 17, 1, 5);
                    verifyChecksum(id);
                    break; 
            }
        }

        //compare the last char with checksum
        private void verifyChecksum(string id)
        {
            char[] cs = id.ToCharArray();
            int result = 0 ;

            try
            {
                for (int i = 0; i < 17; i++)
                {
                    result += int.Parse(cs[i].ToString()) * coef[i];
                }

                result = result % 11;
                if (cs[17] == checksum[result])
                {
                    labResult.BackColor = Color.Green;
                    labResult.Text = "校验成功";
                }
                else
                {
                    labResult.BackColor = Color.Red;
                    labResult.Text = "校验失败";
                }
            }
            catch(Exception e)
            {
                labResult.BackColor = Color.Yellow;
                labResult.Text = e.Message;
            }
        }


        private string findLocation(string code)
        {
            for(int i=0; i<idlocList.GetLength(0); i++)
            {
                if(idlocList[i, 0] == code)
                    return(idlocList[i, 1]);
            }

            return "不存在的地区";
        }


        private bool verifyPat(string id, int loc, int len, int ipat)
        {
            bool tf = Regex.IsMatch(id.Substring(loc, len), pats[ipat]);
            highlight(loc, len, tf ? Color.Green : Color.Red);
            return tf;
        }

        private void highlight(int loc, int len, Color color)
        {
            rtfInputbox.Select(loc, len);
            rtfInputbox.SelectionColor = color;
            rtfInputbox.Select(rtfInputbox.TextLength, 0);
            rtfInputbox.Select(loc+len, 0);
            rtfInputbox.SelectionColor = Color.Black;
        }

        private void rtfInputbox_TextChanged(object sender, System.EventArgs e)
        {
            choosePat(((RichTextBox)sender).Text);
        }

        // read id-location list from id.txt
        private void readList()
        {
            StreamReader sr = new StreamReader("id.txt", Encoding.Default);
            string content = sr.ReadToEnd();

            string[] lines = content.Split('\n');
            idlocList = new string[lines.Length, 2];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] _idloc = lines[i].Trim().Split('\t');
                idlocList[i, 0] = _idloc[0];
                idlocList[i, 1] = _idloc[1];
            }
            
        }
    }
}

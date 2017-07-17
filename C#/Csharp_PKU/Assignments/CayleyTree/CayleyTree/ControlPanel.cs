using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{

    public partial class ControlPanel : Form
    {
        Form frmCayleyTree;

        public ControlPanel()
        {
            InitializeComponent();
            formLoad();
        }

        private void formLoad()
        {
            this.TopMost = true;
            btnRedraw.Click += btnRedraw_Click;

            defalutArgs();

            frmCayleyTree = new CayleyTree();
            frmCayleyTree.Show();
        }

        private void defalutArgs()
        {
            tkbSize.Value = 10;
            tkbLen.Value = 100;
            tkbNum.Value = 10;
            tkbAng.Value = 25;

            numAng.Value = 1;
            numPos.Value = 1;
            numLen.Value = 1;

            cbxColor.SelectedIndex = 3;

        }

        private void redraw()
        {
            TS.Trunk_Size = tkbSize.Value;
            TS.Trunk_Length = tkbLen.Value;

            TS.Branch_Angle = tkbAng.Value * Math.PI / 180;
            TS.Branch_Num = tkbNum.Value;

            TS.Coff_Ang = (double)numAng.Value;
            TS.Coff_Len = (double)numLen.Value;
            TS.Coff_Pos = (double)numPos.Value;
            TS.Coff_SubT = (double)numSubT.Value;

            TS.Color_R = (int)numR.Value;
            TS.Color_G = (int)numG.Value;
            TS.Color_B = (int)numB.Value;
            TS.R = ckbR.Checked;
            TS.G = ckbG.Checked;
            TS.B = ckbB.Checked;
   
            frmCayleyTree.Invalidate();
        }

        private void btnRedraw_Click(object sender, EventArgs e)
        {
            redraw();
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            switch (((TrackBar)sender).Name)
            {
                case "tkbSize":
                    labSize.Text = tkbSize.Value.ToString();
                    break;
                case "tkbLen":
                    labLen.Text = tkbLen.Value.ToString();
                    break;
                case "tkbNum":
                    labNum.Text = tkbNum.Value.ToString();
                    break;
                case "tkbAng":
                    labAng.Text = tkbAng.Value.ToString();
                    break;

            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            defalutArgs();
            redraw();
        }

        private void rdbMode_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
                return;

            switch (((RadioButton)sender).Text)
            {
                case "Mode 1":
                    TS.Color_Mode = 1;
                    break;
                case "Mode 2":
                    TS.Color_Mode = 2;
                    break;
            }
        }

        private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxColor.Text.Contains("Random"))
            {
                TS.Color_Mode = 1;
            }
            else
            {
                TS.Color = Color.FromName(cbxColor.Text);
                TS.Color_Mode = 0;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            switch (((NumericUpDown)sender).Name)
            {
                case "numR":
                    TS.Color_R = (int)numR.Value;
                    break;
                case "numG":
                    TS.Color_G = (int)numG.Value;
                    break;
                case "numB":
                    TS.Color_B = (int)numB.Value;
                    break;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRondom_Click(object sender, EventArgs e)
        {
            TS.Random = TS.Random ? false : true;
            ((Button)sender).Text = TS.Random ? "Random" : "Normal";

            redraw();
        }
    }

    public static class TS
    {
        public static float Trunk_Size = 5f; 
        public static double Trunk_Length = 100d;

        public static int Branch_Num = 10; //递归次数
        public static double Branch_Angle = 25 * Math.PI / 180; //弧度;
        public static double Coff_Len = 1d; //两子树的长度差系数
        public static double Coff_Ang = 1d;
        public static double Coff_Pos = 1d; //两子树的位置的系数K
        public static double Coff_SubT = 0.8d; //主干

        public static Color Color;
        public static int Color_Mode = 1;
        public static int Color_R = 111;
        public static int Color_G = 222;
        public static int Color_B = 111;
        public static bool R;
        public static bool G;
        public static bool B;

        public static bool Random = true;
       


    }
}

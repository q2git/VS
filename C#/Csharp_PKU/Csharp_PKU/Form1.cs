using System;
//using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Csharp_PKU
{

    public partial class Form1 : Form
    {
        //[DllImport("kernel32.dll")]
        //public static extern Boolean AllocConsole();
        //[DllImport("kernel32.dll")]
        //public static extern Boolean FreeConsole();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Week3.IndexerRecord.Test();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AllocConsole();
            Week3.Student.Test(); //To see output, press Ctrl+Alt+O
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Week3.TestInterface.Test();
            Week3.InterfaceExplicitImpl.Test();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Week3.TestStruct.Test();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Week3.TestEnum.Test();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Week4.DelegateIntegral.Test();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Week4.TestMultiCastDelegate.Test();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Week4.TestEvent.Test();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Week4.Lambda frmLambda = new Week4.Lambda();
            frmLambda.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Week4.TestException.Test();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Week4.MemberInfo_GetCustomAttributes.Test();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Week4.TestUnsafe.Test();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Week5.ListTest.Test();
            //Week5.SamplesHashtable.Test();
        }

        private void button14_Click(object sender, EventArgs e)
        {    
            Week5.TestDebugPi.Test(10);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Week5.Fibonacci.Test();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Form frmTree = new Week5.Recursion_CaylayTree();
            Form frmTree = new Week5.Recursion_CaylayTree2();
            frmTree.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Week6.ListAllFiles.Test();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Week6.Watcher.Test();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //Week6.Logger.Test();
            Week6.TextReadWrite.Test();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form frmBinReader = new Week6.Form1();
            frmBinReader.Show();
            //Week6.BMPGenerator.GenBMP("Test.bmp", "hello world");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Week6.SerializationTest.Program.TestBinary();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string strRegkey = Week6.GpsTerm.Util.RegistryUtil.GetRegValue(
                Microsoft.Win32.Registry.CurrentUser,
                @"Software\WinRAR\ArcHistory", "0");
            MessageBox.Show(strRegkey);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form frmCalc = new Week7.calcForm();
            frmCalc.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form frmFileManager = new Week7.FileManager();
            frmFileManager.Show();
        }

        private void btnShow_Clicked(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "CheckBox RadioButton":
                    new Week7.CheckBoxRadioButton().Show();
                    break;
                case "Checked ListBox":
                    new Week7.CheckedListBox().Show();
                    break;
                case "ComboBox":
                    new Week7.ComboBox().Show();
                    break;
                case "DateTime Picker":
                    new Week7.DateTimePicker().Show();
                    break;
                case "Error Provider":
                    new Week7.ErrorProvider().Show();
                    break;
                case "FileOpen Dialog":
                    new Week7.FileOpenDialog().Show();
                    break;
                case "Month Calendar":
                    new Week7.Calendar().Show();
                    break;
                case "PictureBox":
                    new Week7.PictureBox().Show();
                    break;
                case "ProgressBar":
                    new Week7.ProgressBar().Show();
                    break;
                case "ScrollBar TrackBar":
                    new Week7.ScrollBarTrackBar().Show();
                    break;
                case "Timer ProgressBar":
                    new Week7.TimerProgressBar().Show();
                    break;
                case "UpDown":
                    new Week7.UpDown().Show();
                    break;
                case "TreeView":
                    new Week7.TreeViewTest().Show();
                    break;
                case "Spliter":
                    new Week7.Spliter().Show();
                    break;
                case "Panel AutoScroll":
                    new Week7.PanelAutoScroll().Show();
                    break;
                case "ListView":
                    new Week7.ListViewTest().Show();
                    break;
                case "ListBox":
                    new Week7.ListBoxTest().Show();
                    break;
                case "ImageListTest":
                    new Week7.ImageListTest().Show();
                    break;
                case "Panel And Layout":
                    new Week7.PanelAndLayout().ShowDialog();
                    break;
                case "Pen Test":
                    new Week8.PenTest().ShowDialog();
                    break;
                case "Font Test":
                    new Week8.FontTest().ShowDialog();
                    break;
                case "Brush Test":
                    new Week8.BrushTest().ShowDialog();
                    break;
                case "Draw Func":
                    new Week8.DrawFunc().ShowDialog();
                    break;
                case "Transform":
                    new Week8.TransformTest().ShowDialog();
                    break;
                case "PathGradient":
                    new Week8.PathGradient().ShowDialog();
                    break;
                case "Regex Test":
                    Week9.RegexTest.Test();
                    break;
                case "Regex Phone":
                    Week9.RegexPhone.Test();
                    break;
                case "WebClient":
                    Week10.WebClientTest.Test();
                    break;
                case "WebRequest":
                    Week10.DownloadStringTest.Test();
                    break;
                case "WebEncoding":
                    Week10.PageEncoding.Test();
                    break;
                case "DownloadImg":
                    Week10.DownloadImg.Test();
                    break;
                case "XmlDocTest":
                    Week10.XmlDocTest.Test();
                    break;
                case "XmlReader":
                    Week10.XmlReaderTest.Test();
                    break;
                case "XmlWriter":
                    Week10.XmlWriterTest.Test();
                    break;
            }
        }
    }
}

﻿using System;
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
    }
}

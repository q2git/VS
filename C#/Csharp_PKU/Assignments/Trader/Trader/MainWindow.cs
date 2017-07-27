using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trader
{
    public partial class MainWindow : Form
    {
        private delegate void addQuotePanelDelegate(Control ctrl);

        public MainWindow()
        {
            InitializeComponent();
            LoadControl();
            //addQuotePanel();
        }


        private void LoadControl()
        {
            for (int i = 0; i < 4; i++)
            {
                Thread thread = new Thread(new ThreadStart(showPanel));
                thread.Name = "Thread " + i.ToString();
                thread.IsBackground = true;
                thread.Start();
            }

        }

        private void showPanel()
        {
            addQuotePanel();
        }

        private void addQuotePanel()
        {
            QuotePanel qt = new QuotePanel();
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new addQuotePanelDelegate(this.tableLayoutPanel1.Controls.Add), qt);
            }
            else
            {
                this.tableLayoutPanel1.Controls.Add(qt);
            }
        }

    }
}

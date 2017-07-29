using System;
using System.Collections;
using System.Collections.Generic;
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
    public partial class QuotePanel : UserControl
    {
        HttpClient _httpClient;
        private string _period = "min";
        private Hashtable _codes;
        private CancellationTokenSource _cts;

        Dictionary<string, string[]> _urls = new Dictionary<string, string[]>
        {
            {"沪市主板", new string[]{
                "http://www.cninfo.com.cn/information/sh/mb/shmblclist.html",
                "http://hq.sinajs.cn/list=sh",
                "http://image.sinajs.cn/newchart/{0}/n/sh{1}.gif"}
            },
            {"深市主板", new string[]{
                "http://www.cninfo.com.cn/information/sz/mb/szmblclist.html",
                "http://hq.sinajs.cn/list=sz",
                "http://image.sinajs.cn/newchart/{0}/n/sz{1}.gif"}
            },
            {"中小企业板", new string[]{
                "http://www.cninfo.com.cn/information/sz/sme/szsmelclist.html",
                "http://hq.sinajs.cn/list=sz",
                "http://image.sinajs.cn/newchart/{0}/n/sz{1}.gif"}
            },
            {"创业板", new string[]{
                "http://www.cninfo.com.cn/information/sz/cn/szcnlclist.html" ,
                "http://hq.sinajs.cn/list=sz",
                "http://image.sinajs.cn/newchart/{0}/n/sz{1}.gif"}
            }
        };

        public QuotePanel(HttpClient client, Hashtable codes)
        {
            _httpClient = client;
            _codes = codes;

            InitializeComponent();
        }

        private void QuotePanel_Load(object sender, EventArgs e)
        {

            this.Dock = DockStyle.Fill;
            btnMin.Enabled = false;
            btnMin.BackColor = Color.Yellow;

            cbxMarket.DataSource = _urls.Keys.ToList();

            //labName.Text = Thread.CurrentThread.ManagedThreadId.ToString();

            _cts = new CancellationTokenSource();
            Run(_cts.Token);
        }

        //get html content from url
        private async Task<string> GetHttpString(string url)
        {
            try
            {
                byte[] buffer = await _httpClient.GetByteArrayAsync(url);
                string html = Encoding.Default.GetString(buffer);
                return html;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //get chart for stock code
        private async Task<Bitmap> GetHttpImage(string code)
        {
            try
            {
                string url = string.Format(_urls[cbxMarket.Text][2], _period, code);

                byte[] buffer = await _httpClient.GetByteArrayAsync(url);
                MemoryStream ms = new MemoryStream(buffer);
                Bitmap bmp = new Bitmap(ms);
                return bmp;
                
            }
            catch(Exception e)
            {
                //show loading image on exception
                return Properties.Resources.loading;
            }

        }

        //change the K-chart type
        private void btnPeriod_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            //reset all buttons
            foreach (var bt in flowLayoutPanel1.Controls)
            {
                if (!(bt is Button)) continue;
                if (((Button)bt).Name == "btnRun") continue;

                ((Button)bt).BackColor = Color.White;
                ((Button)bt).Enabled = true;
            }

            btn.Enabled = false;
            btn.BackColor = Color.Yellow;
            _period = btn.Text;
            
        }


        //Update stock list as the change of the market
        private void cbxMarket_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxStock.Enabled = false;
            cbxStock.DataSource = _codes[cbxMarket.Text];
            cbxStock.Enabled = true;
        }


        //Update trading data
        private async void Run(CancellationToken ct)
        {
            Random rnd = new Random();

            while (true)
            {
                if (ct.IsCancellationRequested) return;

                if (cbxStock.Text.Length > 6)
                {
                    try
                    {
                        //if (rnd.Next(10) == 1) throw new Exception(); //test

                        //show stock randomly after market closed at 15:00
                        int n = rnd.Next(cbxStock.Items.Count);
                        string code = DateTime.Now.Hour>9 && DateTime.Now.Hour < 15 ? 
                                      cbxStock.Text : cbxStock.Items[n].ToString();
                        code = code.Substring(0, 6); 
                        string url = _urls[cbxMarket.Text][1] + code;

                        //current price
                        string[] quote = (await GetHttpString(url)).Split(',');
                        labPrice.Text = quote[3];

                        //price change rate
                        float percent = float.Parse(quote[3]) / float.Parse(quote[2]) - 1;
                        labPercent.Text = string.Format("{0:P}", percent);
                        labPrice.BackColor = labPercent.BackColor = percent > 0f ? Color.Red : Color.Green;
                       
                        //trend chart
                        picChart.Image = await GetHttpImage(code);

                        labTime.Text = DateTime.Now.ToLongTimeString();
                    }
                    catch (Exception e)
                    {
                        //show loading image on exception
                        picChart.Image = Properties.Resources.loading; 
                    }

                }
                await Task.Delay(5000);
            }

        }

        
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (_cts.IsCancellationRequested)
            {
                _cts = new CancellationTokenSource();
                Run(_cts.Token);
                btnRun.Text = "Stop";
                btnRun.BackColor = Color.LightGray;
            }
            else
            {
                _cts.Cancel();
                btnRun.BackColor = Color.LightGreen;
                btnRun.Text = "Run";
            }
        }


    }
}

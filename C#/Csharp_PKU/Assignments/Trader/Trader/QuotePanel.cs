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
        private string _period = "min";
        private Hashtable _codes = new Hashtable(); //_codes[Market] = CodeList
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

        public QuotePanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            cbxMarket.DataSource = _urls.Keys.ToList();
            btnMin.Enabled = false;
            btnMin.BackColor = Color.Yellow;
            labName.Text = Thread.CurrentThread.Name;
        }

        //Get string from url
        private async Task<string> GetHttpString(string url)
        {
            HttpClient client = new HttpClient();
            byte[] buffer = await client.GetByteArrayAsync(url);
            string html = Encoding.Default.GetString(buffer);
            return html;
        }

        //Get chart for stock code
        private async Task<Bitmap> GetHttpImage(string code)
        {
            HttpClient client = new HttpClient();
            string url = string.Format(
                _urls[cbxMarket.Text][2],
                _period,
                code
                );

            byte[] buffer = await client.GetByteArrayAsync(url);
            MemoryStream ms = new MemoryStream(buffer);
            Bitmap bmp = new Bitmap(ms);
            return bmp;
        }

        //Get stock list from url
        private async Task<List<string>> GetStockList(string url)
        {
            string pat = @"[0,3,6]\d{5} [\u4e00-\u9fa5]{3,4}";
            string html = await GetHttpString(url);
            MatchCollection matchList = Regex.Matches(html, pat);
            //copied form SO, convert matchlist to list
            var list = matchList.Cast<Match>().Select(match => match.Value).ToList();
            return list;
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            //reset all buttons
            foreach (var ct in this.flowLayoutPanel1.Controls)
            {
                if (!(ct is Button)) continue;
                ((Button)ct).BackColor = Color.White;
                ((Button)ct).Enabled = true;
            }

            btn.Enabled = false;
            btn.BackColor = Color.Yellow;
            _period = btn.Text;
            
        }


        //Update stock list as the change of the market
        private async void cbxMarket_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxStock.Enabled = false;

            if (!_codes.ContainsKey(cbxMarket.Text))
                _codes.Add(cbxMarket.Text, await GetStockList(_urls[cbxMarket.Text][0]));

            cbxStock.DataSource = _codes[cbxMarket.Text];

            cbxStock.Enabled = true;
        }


        //Update trading data
        private async void cbxStock_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(cbxStock.Text.Length > 6)) return;

            string code = ((ComboBox)sender).Text.Substring(0, 6);
            string url = _urls[cbxMarket.Text][1] + code;

            //textBox1.Text = await GetHttpString(url);
            picChart.Image = await GetHttpImage(code);
            //pictureBox2.Image = await GetHttpImage(code);
        }

        //Update trading data
        private async void Run()
        {
            Random rnd = new Random();

            while (true)
            {
                if (cbxStock.Text.Length > 6)
                {
                    try
                    {
                        int n = rnd.Next(cbxStock.Items.Count);
                        string code = cbxStock.Items[n].ToString().Substring(0, 6);

                        //string code = cbxStock.Text.Substring(0, 6);
                        string url = _urls[cbxMarket.Text][1] + code;
                        labPercent.Text = await GetHttpString(url);

                        picChart.Image = await GetHttpImage(code);

                        labTime.Text = DateTime.Now.ToLongTimeString();
                    }catch(Exception e)
                    {
                        txtError.Text = e.Message;
                    }

                }
                await Task.Delay(10000);
            }

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Run();
        }
    }
}

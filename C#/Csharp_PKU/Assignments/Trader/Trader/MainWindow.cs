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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trader
{
    public partial class MainWindow : Form
    {

        Dictionary<string, string[]> urls = new Dictionary<string, string[]>
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

        Hashtable codelist = new Hashtable();

        public MainWindow()
        {
            InitializeComponent();
            Form_Load();
        }

        private void Form_Load()
        {
            cbxMarket.DataSource = urls.Keys.ToList();
            

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
        private async Task<Bitmap> GetHttpImage(string code, string period="min")
        {
            HttpClient client = new HttpClient();
            string url = string.Format(
                urls[cbxMarket.Text][2],
                period,
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


        //Update stock list as the change of the market
        private async void cbxMarket_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxStock.Enabled = false;

            if (!codelist.ContainsKey(cbxMarket.Text))
                codelist.Add(cbxMarket.Text, await GetStockList(urls[cbxMarket.Text][0]));

            cbxStock.DataSource = codelist[cbxMarket.Text];

            cbxStock.Enabled = true;
        }

        //Update trading data
        private async void cbxStock_SelectedValueChanged(object sender, EventArgs e)
        {
            string code = ((ComboBox)sender).Text.Substring(0, 6);
            string url = urls[cbxMarket.Text][1] + code;

            textBox1.Text = await GetHttpString(url);
            //pictureBox1.Image = await GetHttpImage(code);
            //pictureBox2.Image = await GetHttpImage(code);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel fp = new FlowLayoutPanel();
            //fp.Dock = DockStyle.Fill;
            fp.FlowDirection = FlowDirection.TopDown;
            Button btn = new Button();
            btn.Text = "Daily";
            
            
            PictureBox pic1 = new PictureBox();
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.Dock = DockStyle.Fill;
            pic1.Image = await GetHttpImage("600596");
            //btn.Dock = DockStyle.Top;
           // pic1.Controls.Add(btn);
            //fp.Controls.Add(btn);
            fp.Controls.Add(pic1);
            //tableLayoutPanel1.Controls.Add(pic1);
            tableLayoutPanel1.Controls.Add(pic1);
        }
    }
}

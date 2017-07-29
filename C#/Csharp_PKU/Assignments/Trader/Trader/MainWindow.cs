using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
        private HttpClient _httpClient;
        private Hashtable _codes;

        public MainWindow()
        {
            _httpClient = new HttpClient() { Timeout=TimeSpan.FromSeconds(15) };
            _codes = new Hashtable();

            InitializeComponent();

        }

        //show loading gif before _codes been initializing
        private async void MainWindow_Load(object sender, EventArgs e)
        {
            //centering the picturebox
            picLoading.Top = (Height - picLoading.Height) / 2;
            picLoading.Left = (Width - picLoading.Width) / 2;

            picLoading.Visible = true;

            await initCodes();

            picLoading.Visible = false;

            AddPanel();
        }

        //initialize the hashtable _codes
        private async Task initCodes()
        {
            Dictionary<string, string> urls = new Dictionary<string, string>{
                {"沪市主板", "http://www.cninfo.com.cn/information/sh/mb/shmblclist.html"},
                {"深市主板", "http://www.cninfo.com.cn/information/sz/mb/szmblclist.html"},
                {"中小企业板", "http://www.cninfo.com.cn/information/sz/sme/szsmelclist.html"},
                {"创业板", "http://www.cninfo.com.cn/information/sz/cn/szcnlclist.html"}};

            foreach (string mkt in urls.Keys)
            {
                List<string> clist = await GetStockList(urls[mkt]);
                _codes.Add(mkt, clist);
            }

        }

        //downloading stock list from url
        private async Task<List<string>> GetStockList(string url)
        {
            string pat = @"[0,3,6]\d{5} [\u4e00-\u9fa5]{3,4}";

            byte[] buffer = await _httpClient.GetByteArrayAsync(url);
            string html = Encoding.Default.GetString(buffer);

            MatchCollection matchList = Regex.Matches(html, pat);
            //convert matchlist to list
            return matchList.Cast<Match>().Select(match => match.Value).ToList();
 
        }

        //add four quote panels to main window
        private void AddPanel()
        {
            for (int i = 0; i < 4; i++)
            {
                this.tableLayoutPanel1.Controls.Add(new QuotePanel(_httpClient, _codes));
            }

        }

    }
}

using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace WebCrawler
{

    class Crawler
    {
        private WebClient webClient = new WebClient();
        private Hashtable urls = new Hashtable();
        private int count = 0;

        public Crawler(string startUrl)
        {
            urls.Add(startUrl, false);
        }

        public Hashtable URLs
        {
            get { return urls; }
        }

        public void Crawl()
        {
            Console.WriteLine("Crawler Started....");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys) //找到一个还没有下载过的链接
                {
                    if ((bool)urls[url]) continue; //已经下载过的，不再下载
                    current = url;
                }
                if (current == null || count > 100) break;

                Console.WriteLine("Crawling " + current + " ...");

                string html = DownLoad(current); //下载

                urls[current] = true;

                count++;

                Parse(html); //解析，并加入新的链接
            }
            Console.WriteLine("Crawler Stopped");
        }

        public string DownLoad(string url)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Timeout = 30000;
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                byte[] buffer = ReadInstreamIntoMemory(response.GetResponseStream());
                //string fileName = count.ToString();
                Uri uri = new Uri(url);
                string fileName = Path.GetFileName(uri.LocalPath);
                //string fileName = uri.Segments.Last();
                if (fileName != "")
                {
                    string path = "donwload";// Directory.GetCurrentDirectory() + @"\download";
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    path = Path.Combine(path, fileName);

                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    fs.Write(buffer, 0, buffer.Length);
                    fs.Close();
                }

                string html = Encoding.UTF8.GetString(buffer);
                return html;
            }
            catch
            {
            }
            return "";
        }

        public void Parse(string html)
        {
            string strRef = @"(href|HREF|src|SRC)[ ]*=[ ]*[""'][^""'#>]+[""']";
            //string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\'', '#', ' ', '>');
                if (strRef.Length == 0) continue;

                if (urls[strRef] == null && strRef.StartsWith("http")) //absolute address
                    urls[strRef] = false;
            }
        }

        private static byte[] ReadInstreamIntoMemory(Stream stream)
        {
            int bufferSize = 16384;
            byte[] buffer = new byte[bufferSize];
            MemoryStream ms = new MemoryStream();
            while (true)
            {
                int numBytesRead = stream.Read(buffer, 0, bufferSize);
                if (numBytesRead <= 0) break;
                ms.Write(buffer, 0, numBytesRead);
            }
            return ms.ToArray();
        }

    }

}

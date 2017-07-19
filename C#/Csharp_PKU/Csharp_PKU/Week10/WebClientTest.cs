using System;
using System.Net;
using System.Text;

namespace Csharp_PKU.Week10
{
    class WebClientTest
    {

        public static void Test()

        {

            string url = @"http://www.baidu.com";

            WebClient client = new WebClient();

            byte[] pageData = client.DownloadData(url);

            string pageHtml = Encoding.Default.GetString(pageData);

            Console.WriteLine(pageHtml);

        }

    }
}


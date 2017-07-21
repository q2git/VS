using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input address: ");
            string addr = Console.ReadLine().ToString();

            Crawler myCrawler = new Crawler(addr);
            myCrawler.Crawl();
        }
    }
}

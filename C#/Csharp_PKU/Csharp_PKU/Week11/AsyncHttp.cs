using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_PKU.Week11
{
    class AsyncHttp
    {

        int tasks = 3;

        Queue<string> results = new Queue<string>();

        string baseUrl = "http://www.baidu.com";

        public void Start()

        {

            Task[] tasks = new Task[this.tasks];

            for (int i = 0; i < this.tasks; ++i)

            {

                tasks[i] = this.Perform(i);

            }

            Task.WaitAll(tasks);

            results.ToList().ForEach(Console.WriteLine);

        }

        public async Task Perform(int state)

        {

            string url = String.Format("{0}{1}", this.baseUrl, state.ToString().PadLeft(3, '0'));

            var client = new HttpClient();

            Stopwatch timer = new Stopwatch();

            timer.Start();

            string result = await client.GetStringAsync(baseUrl);

            timer.Stop();

            this.results.Enqueue(String.Format("{0,4}\t{1,5}\t{2}", url, timer.ElapsedMilliseconds, result));

        }

    }
}

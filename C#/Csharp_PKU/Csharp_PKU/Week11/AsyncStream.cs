using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_PKU.Week11
{
    public class AsyncStream

    {

        async Task<int> WriteFile()

        {

            using (StreamWriter sw = new StreamWriter(

            new FileStream("aaa.txt", FileMode.Create)))

            {
                Console.WriteLine("Writting...");
                Thread.Sleep(1000);
                await sw.WriteAsync("my text");
                Console.WriteLine("Wrote.");
                return 1;

            }

        }

        public async static void Test()

        {

            AsyncStream a = new AsyncStream();
            Console.WriteLine("begin");
            await a.WriteFile();

            Console.WriteLine("Write OK");

        }

        //static void Main()

        //{

        //    Test();

        //}
    }
}
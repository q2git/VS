using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_PKU.Week11
{
    class AwaitTest
    {

        Task<double> FacAsync(int n)

        {

            return Task<double>.Run(() => {
                Thread.Sleep(5000);
                double s = 1;

                for (int i = 1; i < n; i++) s = s * i;

                return s;

            });

        }

        async void TestAsyc()

        {

            // 调用异步方法

            double result = await FacAsync(10);
            Console.WriteLine(result); //想想这句在哪个线程

        }

        public void Test()
        {

            TestAsyc();
            Console.WriteLine("Main Waitting...");
            //Console.ReadKey();

        }
    }
}

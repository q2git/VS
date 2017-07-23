using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_PKU.Week11
{
    class TaskTest
    {

        public static void Test()

        {

            Task<double>[] tasks = {

                Task.Run( ()=>DoSometing() ),

                Task.Run( ()=>SomeFun() ),

                };

            Thread.Sleep(1);

            for (int i = 0; i < tasks.Length; i++)

            {

                Console.WriteLine(tasks[i].Status); //可以查看状态

                Console.WriteLine(tasks[i].Result); //取Result时，会等到计算结束

            }

            Task.WaitAll(tasks); //也可以用这句，来等结束
            Console.WriteLine("All tasks done");
        }

        static double DoSometing() { Thread.Sleep(1050); return DateTime.Now.Millisecond; }

        static double SomeFun() { Thread.Sleep(5000); return DateTime.Now.Millisecond; }

    }
}

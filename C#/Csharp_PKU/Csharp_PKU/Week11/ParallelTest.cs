using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_PKU.Week11
{
    class ParallelTest
    {

        public static void InvokeTest()

        {

            Action[] actions = { new Action(DoSometing), DoSometing };

            Parallel.Invoke(actions);

            Console.WriteLine("主函数所在线程" + Thread.CurrentThread.ManagedThreadId);

            Console.WriteLine("Parallel 'Invoke' Test Done.");
            //Console.ReadKey();

        }

        static void DoSometing()
        {

            Console.WriteLine("函数所在线程" + Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(2000);

        }

        public static void ForTest()

        {

            Parallel.For(0, 10, i =>

            {

                Console.WriteLine("i={0}, fac={1}, 线程id={2}",

                i, Calc(i),

                Thread.CurrentThread.ManagedThreadId);

                Thread.Sleep(10);

            });

            Console.WriteLine("Parallel 'For' Test Done.");
            //Console.ReadLine();

        }

        static double Calc(int n)

        {

            double f = 1;

            for (int i = 1; i <= n; i++) f *= i;

            return f;

        }

        public static void ForEachTest()

        {

            List<double> list = new List<double>();

            for (int i = 0; i < 100; i++) list.Add(i * i);

            ParallelLoopResult loopResult = Parallel.ForEach(

            list, (double x, ParallelLoopState state) =>

            {

                if (x == 400) state.Break();

                Console.WriteLine("x={0},thread id={1}",

                   x, Thread.CurrentThread.ManagedThreadId);

                            }); 

            Console.WriteLine("IsCompleted: {0}",

            loopResult.IsCompleted);

            Console.WriteLine("BreakValue: {0}",

            loopResult.LowestBreakIteration.HasValue);

            Console.WriteLine("Parallel 'ForEach' Test Done.");
            //Console.ReadLine();

        }
    }
}

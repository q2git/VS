using System;

//迭代是函数内某段代码实现循环
namespace Csharp_PKU.Week5
{
    class TestDebugPi

    {

        public static void Test(int intCount)
        {

            double a = 1;

            for (int n = 1; n <= intCount; n++)

            {

                a = Math.Sqrt(2 - Math.Sqrt(4 - a * a));

                double pi = a * 3 * Math.Pow(2, n);

                Console.WriteLine("Count{0} --> {1}", n, pi);

            }

            Console.WriteLine(Math.PI);

            //请调试:如果n<=100,如何? 超出Double范围

        }

    }
}

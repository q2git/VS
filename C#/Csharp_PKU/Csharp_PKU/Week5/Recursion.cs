using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//程序调用自身的编程技巧称为递归
namespace Csharp_PKU.Week5
{
    //求阶乘
    public class Fac

    {

        public static void Test()

        {

            Console.WriteLine("Fac of 5 is " + fac(5));

        }

        static long fac(int n)
        {

            if (n == 0 || n == 1) return 1;

            else return fac(n - 1) * n;

        }

    }
    
    //菲波那契数列
    public class Fibonacci

    {

        public static void Test()

        {

            Console.WriteLine("Fibonacci(10) is " + fib(10));

        }

        static long fib(int n)
        {

            if (n == 0 || n == 1) return 1;

            else return fib(n - 1) + fib(n - 2);

        }

    }


}

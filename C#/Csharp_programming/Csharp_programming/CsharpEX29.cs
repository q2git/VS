using System;

//例29 除数为0的异常

//除数为0，捕获异常

//格式不正确，捕获异常

namespace CsharpEX29

{

    class Program

    {

        public static void Example()

        {

            bool flag = true;

            while (flag)

            {

                try

                {

                    int a = Convert.ToInt32(Console.ReadLine());

                    int b = Convert.ToInt32(Console.ReadLine());

                    int c = a / b;

                    Console.WriteLine(c);

                    flag = false;

                }

                catch (DivideByZeroException divideByZero)

                {

                    Console.WriteLine(divideByZero.Message);

                    Console.WriteLine("Try Again");

                }

                catch (FormatException formatException)

                {

                    Console.WriteLine(formatException.Message);

                    Console.WriteLine("Try Again");

                }

            }

        }

    }

}


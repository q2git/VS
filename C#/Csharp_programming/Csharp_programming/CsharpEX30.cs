using System;

//例30 抛出异常

//自定义异常

//.NET的异常层次

//throw和finally

namespace CsharpEX30

{

    class Program

    {

        public static void Example()

        {

            try

            {

                FFF f = new FFF();

                f.Age = -8;

            }

            catch (MyException e)

            {

                Console.WriteLine(e.Message);
                //throw (new StackOverflowException());

            }

            finally

            {

                Console.WriteLine("Finally");

            }

        }

    }

    public class FFF

    {

        private int age;

        public int Age

        {

            get { return age; }

            set

            {

                if (value >= 0)

                {

                    age = value;

                }

                else

                {

                    age = 0;

                    throw (new MyException());

                }

            }

        }

    }

    public class MyException : Exception

    {

        public MyException() : base("Age should be over zero!") { }

        public MyException(string message) : base(message) { }

        public MyException(string message, Exception e) : base(message, e) { }

    }

}


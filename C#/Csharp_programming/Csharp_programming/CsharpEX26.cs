using System;

//例26 运算符重载

namespace CsharpEX26

{

    class Program

    {

        public static void Example()

        {

            Complex x1 = new Complex(1, 2);

            Complex x2 = new Complex(2, 3);

            Complex x3 = x1.Add(x2);

            Complex x4 = x1 + x2;

            Console.WriteLine(x3);

            Console.WriteLine(x4);

        }

    }

    public class Complex

    {

        private double real;

        private double image;

        public Complex(double r, double i)

        {

            real = r;

            image = i;

        }

        public void Set(double r, double i)

        {

            real = r;

            image = i;

        }

        public override string ToString() //重载Object类的ToString方法，使用实例名时默认调用ToString()方法
            
        {

            return String.Format("{0}+{1} i", real, image);
           
        }

        public Complex Add(Complex x)

        {

            Complex t = new Complex(0, 0);

            t.real = x.real + real;

            t.image = x.image + image;

            return t;

        }

        public static Complex operator +(Complex x1, Complex x2) //运算符重载,只能为静态方法

        {

            Complex t = new Complex(0, 0);

            t.real = x1.real + x2.real;

            t.image = x1.image + x2.image;

            return t;

        }

    }

}


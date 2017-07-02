using System;

//例19 复数类

//构建一个复数类

//实现复数的加减乘除

namespace CsharpEX19

{

    class Program

    {

        public static void Example19()

        {

            Complex x1 = new Complex(2, 3);

            Complex x2 = new Complex(5.6, 7.8);

            Complex x3 = x1.Add(x2);

            x3.ShowMe();

            Complex x4 = Complex.Add(x1, x2);

            x4.ShowMe();

        }

    }

    public class Complex

    {

        private double real;

        private double image;

        public Complex()

        {

            real = image = 0;

        }

        public Complex(double real, double image)

        {

            this.real = real;

            this.image = image;

        }

        public void Set(double real, double image)

        {

            this.real = real;

            this.image = image;

        }

        public double GetReal()

        {

            return real;

        }

        public double GetImage()

        {

            return image;

        }

        public Complex Add(Complex x)

        {

            Complex temp = new Complex();

            temp.real = this.real + x.real;

            temp.image = this.image + x.image;

            return temp;

        }

        public static Complex Add(Complex x1, Complex x2)

        {

            Complex temp = new Complex();

            temp.real = x1.real + x2.real;

            temp.image = x1.image + x2.image;

            return temp;

        }

        public Complex Sub(Complex x)

        {

            Complex temp = new Complex();

            temp.real = this.real - x.real;

            temp.image = this.image - x.image;

            return temp;

        }

        public void ShowMe()

        {

            Console.Write("{0}+{1}i", real, image);

        }

    }

}


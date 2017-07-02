using System;

//例21 继承（点和圆）

//创建一个点类。

//从点类继承，创建一个圆类，点是圆心，

//添加半径，计算面积

namespace CsharpEX21

{

    class Program

    {

        public static void Example()

        {

            Circle c1 = new Circle();

            c1.Show2();

            Circle c2 = new Circle(2, 3, 4);

            c2.Show2();

            c2.Show();

        }

    }

    public class Point

    {

        protected double x;

        protected double y;

        public Point()

        {

            x = y = 0;

        }

        public Point(double x1, double y1)

        {

            x = x1;

            y = y1;

        }

        public void Show()

        {

            Console.Write("x={0} y={1}", x, y);

        }

    }

    public class Circle : Point

    {

        protected double r;

        public Circle()

        {

            r = 0;

        }

        public Circle(double x1, double y1, double r1) : base(x1, y1)

        {

            r = r1;

        }

        public double Area()

        {

            return Math.PI * r * r;

        }

        public void Show2()

        {

            Show();

            Console.Write(" r={0}", r);

        }

    }

}
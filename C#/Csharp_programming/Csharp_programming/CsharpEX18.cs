using System;

//例18 点类和直线类

//编写一个点类，描述平面上的2个点（double）

//编写一个直线类，含有2个点，计算2点之间的距离

namespace CsharpEX18

{

    class Program

    {

        public static void Example18()

        {

            Line line1 = new Line();

            Console.WriteLine("Line1 Dis={0}", line1.Distance());

            Line line2 = new Line(1, 1, 3, 3);

            Console.WriteLine("Line2 Dis={0}", line2.Distance());

            Point p1 = new Point(1, 1);

            Point p2 = new Point(3, 3);

            Line line3 = new Line(p1, p2);

            Console.WriteLine("Line3 Dis={0}", line3.Distance());

        }

    }

    class Point

    {

        //private double x;

        //private double y;

        //public double X

        //{

        // set { x = value; }

        // get{return x;}

        //}

        public double X { set; get; }

        public double Y { set; get; }

        public Point()

        {

            X = Y = 0;

        }

        public Point(double x, double y)

        {

            X = x;

            Y = y;

        }

    }

    class Line

    {

        public Point p1;

        public Point p2;

        public Line()

        {

            p1 = new Point();

            p2 = new Point();

        }

        public Line(double x1, double y1, double x2, double y2)

        {

            p1 = new Point(x1, y1);

            p2 = new Point(x2, y2);

        }

        public Line(Point p1, Point p2)

        {

            this.p1 = p1;

            this.p2 = p2;

        }

        public double Distance()

        {

            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));

        }

    }

}
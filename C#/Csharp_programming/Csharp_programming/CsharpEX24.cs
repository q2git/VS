using System;

//例24 多态的演示

namespace CsharpEX24

{

    class Program

    {

        public static void Example()

        {

            Circle c1 = new Circle(1);

            Console.WriteLine(Area(c1));

            Sphere s1 = new Sphere(1);

            Console.WriteLine(Area(s1));

            Cylinder cy1 = new Cylinder(1, 2);

            Console.WriteLine(Area(cy1));

            if (c1 is Cylinder)

            {

                Console.WriteLine("HHH");

            }

        }

        static double Area(Circle c)

        {

            return c.Area();

        }

    }

    public class Circle

    {

        protected double radius;

        public Circle(double r)

        {

            radius = r >= 0 ? r : 0;

        }

        public virtual double Area()

        {

            return Math.PI * radius * radius;

        }

    }

    public class Sphere : Circle

    {

        public Sphere(double r) : base(r) { }

        public override double Area()

        {

            return Math.PI * radius * radius * 4;

        }

    }

    public class Cylinder : Circle

    {

        protected double height;

        public Cylinder(double r, double h) : base(r)

        {

            height = h >= 0 ? h : 0;

        }

        public override double Area()

        {

            return 2 * Math.PI * radius * radius + 2 * Math.PI * height * radius;

        }

    }

}


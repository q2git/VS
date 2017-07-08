using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_PKU.Week3
{
    struct Point

    {

        public double x, y;

        public Point(int x, int y)
        {

            this.x = x;

            this.y = y;

        }

        public double R()
        {

            return Math.Sqrt(x * x + y * y);

        }

    }

    class TestStruct

    {

        public static void Test()  
        {

            Point[] points = new Point[100];

            for (int i = 0; i < 100; i++)

                points[i] = new Point(i, i * i);

            Console.WriteLine(points[5].R());

        }

    }
}

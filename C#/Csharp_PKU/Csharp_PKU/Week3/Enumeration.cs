using System;

namespace Csharp_PKU.Week3
{
    enum LightColor

    {

        Red,

        Yellow,

        Green

    }

    class TrafficLight

    {

        public static void WhatInfo(LightColor color)
        {

            switch (color)
            {

                case LightColor.Red:

                    Console.WriteLine("Stop!");

                    break;

                case LightColor.Yellow:

                    Console.WriteLine("Warning!");

                    break;

                case LightColor.Green:

                    Console.WriteLine("Go!");

                    break;

                default:

                    break;

            }

        }

    }

    class TestEnum

    {

        public static void Test()

        {

            LightColor c = LightColor.Red;

            Console.WriteLine(c.ToString());

            TrafficLight.WhatInfo(c);

        }

    }
}

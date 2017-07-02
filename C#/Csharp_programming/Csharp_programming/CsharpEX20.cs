using System;

//例20 龟兔赛跑

namespace CsharpEX20

{

    class Program

    {

        public static void Example20()

        {

            Runing r1 = new Runing();

            r1.Run();

        }

    }

    class Tortoise

    {

        private int t = 1;

        private Random r;

        public Tortoise()

        {

            r = new Random();

        }

        public int GetPosition()

        {

            int randNum = r.Next(10);

            switch (randNum)

            {

                case 0:

                case 1:

                case 2:

                case 3:

                case 4:

                    t = t + 3;

                    break;

                case 5:

                case 6:

                    t = t - 6 > 0 ? t - 6 : 1;

                    break;

                case 7:

                case 8:

                case 9:

                    t += 1;

                    break;

            }

            return t;

        }

    }

    class Hare

    {

        private int h = 1;

        private Random r;

        public Hare()

        {

            r = new Random();

        }

        public int GetPosition()

        {

            int randNum = r.Next(10);

            switch (randNum)

            {

                case 0:

                case 1:

                    break;

                case 2:

                case 3:

                    h += 9;

                    break;

                case 4:

                    h = h - 12 > 0 ? h - 12 : 1;

                    break;

                case 5:

                case 6:

                case 7:

                    h++;

                    break;

                case 8:

                case 9:

                    h = h - 2 > 0 ? h - 2 : 1;

                    break;

            }

            return h;

        }

    }

    class Runing

    {

        private Tortoise t = new Tortoise();

        private Hare h = new Hare();

        public void Run()

        {

            Console.WriteLine("ON YOUR MARK GET SET");

            Console.WriteLine("BANG!!!");

            Console.WriteLine("AND THEY ARE OFF!");

            int tPos = t.GetPosition();

            int hPos = h.GetPosition();

            while (tPos <= 70 && hPos <= 70)

            {

                Display(tPos, hPos);

                tPos = t.GetPosition();

                hPos = h.GetPosition();

                System.Threading.Thread.Sleep(1000);

            }

            if (tPos > 70)

            {

                Console.WriteLine("Tortoise Win!!");

            }

            else

            {

                Console.WriteLine("Hare Win!!");

            }

        }

        private void Display(int tPos, int hPos)

        {

            char[] dis = new char[70];

            for (int i = 0; i < 70; i++)

            {

                dis[i] = ' ';

            }

            if (tPos == hPos)

            {

                dis[tPos - 1] = 'O';

                dis[tPos] = 'U';

                dis[tPos + 1] = 'C';

                dis[tPos + 2] = 'H';

                dis[tPos + 3] = '!';

            }

            else

            {

                dis[tPos - 1] = 'T';

                dis[hPos - 1] = 'H';

            }

            dis[69] = '|';

            Console.WriteLine(new string(dis));

        }

    }

}


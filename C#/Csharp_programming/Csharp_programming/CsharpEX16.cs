using System;

//例16 类-构造与析构

//设计一个Time类，存储时间（小时，分钟，秒），

//并能以字符串的形式输出

namespace CsharpEX16

{

    class Program

    {

        public static void Example()

        {

            Time t1 = new Time();

            t1.Show();

            Time t2 = new Time(2, 34, 34);

            t2.Show();

            //t2.hour = 12; private 不能被直接访问

        }

    }

    public class Time

    {

        private int hour;

        private int minute;

        private int second;

        public void Show()

        {

            Console.WriteLine("{0:D2} : {1:D2} : {2:D2}", hour, minute, second);

        }

        public Time()

        {

            hour = minute = second = 0;

            Console.WriteLine("Default Construct");

        }

        public Time(int h, int m, int s)

        {

            hour = h >= 0 && h <= 24 ? h : 0;

            minute = m >= 0 && m <= 59 ? m : 0;

            s = s >= 0 && s <= 59 ? s : 0;

            Console.WriteLine("Construct");

        }

        public int Hour

        {

            get { return hour; }

            set { hour = value; }

        }

        ~Time()

        {

            Console.WriteLine("Destroy");

        }

    }

}


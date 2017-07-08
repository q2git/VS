using System;

namespace Csharp_PKU.Week3
{

    interface Runner

    {

        void run();

    }

    interface Swimmer

    {

        void swim();

    }

    abstract class Animal

    {

        abstract public void eat();

    }

    class Person0 : Animal, Runner, Swimmer

    {

        public void run()

        {

            Console.WriteLine("run");

        }

        public void swim()

        {

            Console.WriteLine("swim");

        }

        public override void eat()

        {

            Console.WriteLine("eat");

        }

        public void speak()

        {

            Console.WriteLine("speak");

        }

    }

    class TestInterface

    {

        static void m1(Runner r)

        {

            r.run();

        }

        static void m2(Swimmer s)

        {

            s.swim();

        }

        static void m3(Animal a)

        {

            a.eat();

        }

        static void m4(Person0 p)

        {

            p.speak();

        }

        public static void Test()

        {

            Person0 p = new Person0();

            m1(p);

            m2(p);

            m3(p);

            m4(p);

            Runner a = new Person0();

            a.run();

        }

    }


    //显式接口成员实现

    class InterfaceExplicitImpl

    {

        public static void Test()

        {

            FileViewer f = new FileViewer();

            ((IFileHandler)f).Close();
            f.Test();

            ((IWindow)f).Close();

            IWindow w = new FileViewer();

            w.Close();

        }

    }

    interface IWindow

    {

        void Close();

    }

    interface IFileHandler

    {

        void Close();

    }

    class FileViewer : IWindow, IFileHandler

    {

        void IWindow.Close()

        {

            Console.WriteLine("Window Closed");

        }

        void IFileHandler.Close()

        {

            Console.WriteLine("File Closed");

        }

        public void Test()

        {

            ((IWindow)this).Close();

        }

    }
}

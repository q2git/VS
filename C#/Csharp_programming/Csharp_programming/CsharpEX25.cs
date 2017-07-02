using System;

//例25 宠物类

namespace CsharpEX25

{

    class Program

    {

        public static void Example()

        {

            //Pet p1 = new Pet("Pet", 3);

            //Speak(p1);

            Cat c = new Cat("Jack", 3);

            Dog d = new Dog("Bool", 4);

            Speak(c);

            Speak(d);

        }

        static void Speak(Pet p)

        {

            Console.WriteLine(p);

            p.Speak();

            if (p is Cat) //is Pet

            {

                Console.WriteLine("This is Cat");

            }

        }

    }

    public abstract class Pet

    {

        public string Name { get; private set; }

        public int Age { get; private set; }

        public Pet(string n, int a)

        {

            Name = n;

            Age = a;

        }

        public abstract void Speak();

        public override string ToString()

        {

            return Name;

        }

    }

    public sealed class Cat : Pet //sealed 不允许再继承

    {

        public Cat(string n, int a) : base(n, a) { }

        public override void Speak()

        {

            Console.WriteLine("MIAOMIAO");

        }

    }

    public class Dog : Pet

    {

        public Dog(string n, int a) : base(n, a) { }

        public override void Speak()

        {

            Console.WriteLine("WANGWANG");

        }

    }

}


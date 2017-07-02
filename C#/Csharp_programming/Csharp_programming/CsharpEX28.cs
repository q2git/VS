using System;

//例28 接口

namespace CsharpEX28

{

    class Program

    {

        public static void Example()

        {

        }

    }

    //在接口里面我们可以定义四种东西，分别是 一个方法，一个属性 一个事件，或者是一个索引器
    public interface IPortA //接口命名约定以I开头

    {

        void DisplayA(); //接口成员无修饰符,都为Public, 接口无具体实现方法

    }

    public interface IPortB : IPortA //接口可以继承

    {

        void DisplayB();

    }

    public class AA : IPortB //从接口继承的类必须实现接口所有的方法

    {

        public void DisplayA()

        {

            Console.WriteLine("IPORTA");

        }

        public void DisplayB()

        {

            Console.WriteLine("IPORTB");

        }

    }

}


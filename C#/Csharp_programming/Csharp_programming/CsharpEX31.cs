using System;

using System.Collections.Generic;

//例31 泛型示例

//示例一个泛型方法

//示例泛型类

namespace CsharpEX31

{

    class Program

    {

        public static void Example()

        {

            int[] intA = { 1, 2, 3 };

            double[] dbB = { 1.1, 2.2, 3.3 };

            char[] chC = { 'a', 'b', 'c' };

            Display(intA);

            Display(dbB);

            Display(chC);

            Stack<int> s = new Stack<int>(10);

            System.Collections.Stack s1 = new System.Collections.Stack(12);

        }

        static void Display<T>(T[] a)

        {

            foreach (T k in a)

                Console.WriteLine(k);

        }
      
    }

    //Stack<int> s = new Stack<int>(10);

    //class Stack<Ttype> where Ttype: 泛型约束

    //{

    // private int top;

    // private int bottom;

    // private Ttype[] element;

    // //private object[] element;

    // public Stack(int size)

    // {

    // element = new Ttype[size];

    // }

    //}

}
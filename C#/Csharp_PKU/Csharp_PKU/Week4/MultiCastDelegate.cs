using System;

//• 委托的合并----多播MultiCastDelegate
//一个委托实例中可以“包含”多个函数
//调用委托，就是调用其中多个函数
//多个函数间的先后顺序是没有意义的
//返回值也就没有太多意义
//• 运算符 + - += -=
//动态地增减其中的函数
//提高了程序的灵活性
//• 委托的转换
//按声明的名称判断
//以下两个不能互相转换或加减
//• delegate void D(int a);
//• delegate void E(int a);
//• 委托的相等
//按内容（即其中“包含的函数”）来判断
//有点点像两个字符串的“相等”与否的判断

namespace Csharp_PKU.Week4
{

    delegate void D(int x);

    class C

    {

        public static void M1(int i)

        {

            Console.WriteLine("C.M1: " + i);

        }

        public static void M2(int i)

        {

            Console.WriteLine("C.M2: " + i);

        }

        public void M3(int i)

        {

            Console.WriteLine("C.M3: " + i);

        }

    }

    class TestMultiCastDelegate

    {

        public static void Test()

        {

            D cd1 = new D(C.M1);

            cd1(-1); // call M1

            D cd2 = null;

            cd2 += new D(C.M2);

            cd2(-2); // call M2

            D cd3 = cd1 + cd2;

            cd3(10); // call M1 then M2

            cd3 += cd1;

            cd3(20); // call M1, M2, then M1

            C c = new C();

            D cd4 = new D(c.M3);

            cd3 += cd4;
            Console.WriteLine("call M1, M2, M1, then M3");
            cd3(30); // call M1, M2, M1, then M3

            cd3 -= cd1; // remove last M1
            Console.WriteLine("remove last M1,call M1, M2, then M3");
            cd3(40); // call M1, M2, then M3

            cd3 -= cd4;

            cd3(50); // call M1 then M2

            cd3 -= cd2;

            cd3(60); // call M1

            cd3 -= cd2; // impossible removal is benign

            cd3(60); // call M1

            cd3 -= cd1; // invocation list is empty

            Console.WriteLine(cd3 == null);

            // cd3(70); // System.NullReferenceException thrown

            cd3 -= cd1; // impossible removal

            Console.WriteLine(cd3 == null);

        }

    }
}

using System;

//编译预处理
//• 1．标识符声明
//#define定义一个标识符；
//#undef“取消定义”一个标识符。
//• 2．条件处理
//#if, #elif, #else, #endif
//• 3．信息报告
//#error 和 #warning
//• 4．行号标记
//#line 行号 "文件名"

//unsafe及指针
//• 1．unsafe
//用于修饰类、方法等
//• 2．fixed及指针
//fixed (类型* 指针名 = 表达式 ) 语句
//• 3．sizeof运算符
//sizeof(简单或结构类型名)
//• 4．stackalloc
//在栈上分配的内存，而不是在堆上，因此不会担心内存被垃圾回收器自动回收。

//其他关键字
//• 1．lock
//多线程程序中，lock可以将某个对象加锁
//• 2. volatile
//随时可能被程序以外的其他因素所修改。域被volatile修饰时，会阻止编译器
//对它的优化。


namespace Csharp_PKU.Week4
{
    // 编译时需要: /unsafe
    // Project --> Properties --> Build (Allow unsafe code)

    class TestUnsafe

    {

        static unsafe void Copy(byte[] src, byte[] dst, int count)

        {

            int srcLen = src.Length;

            int dstLen = dst.Length;

            if (srcLen < count || dstLen < count)

            {

                throw new ArgumentException();

            }

            fixed (byte* pSrc = src, pDst = dst)

            {

                byte* ps = pSrc;

                byte* pd = pDst;

                for (int n = 0; n < count; n++)

                {

                    *pd++ = *ps++;

                }

            }

        }

        public static void Test()

        {

            byte[] a = new byte[100];

            byte[] b = new byte[100];

            for (int i = 0; i < 100; ++i)

                a[i] = (byte)i;

            Copy(a, b, 100);

            Console.WriteLine("The first 10 elements are:");

            for (int i = 0; i < 10; ++i)

                Console.Write(b[i] + "{0}", i < 9 ? " " : "");

            Console.WriteLine("\n");

        }

    }

    //指针示例
    //class FileStream : Stream
    //{
    //    int handle;
    //    [DllImport("kernel32", SetLastError = true)]
    //    static extern unsafe bool ReadFile(int hFile,
    //    void* lpBuffer, int nBytesToRead,
    //    int* nBytesRead, Overlapped* lpOverlapped);
    //    public unsafe int Read(byte[] buffer, int index, int count)
    //    {
    //        int n = 0;
    //        fixed (byte* p = buffer)
    //        {
    //            ReadFile(handle, p + index, count, &n, null);
    //        }
    //        return n;
    //    }
    //}
}

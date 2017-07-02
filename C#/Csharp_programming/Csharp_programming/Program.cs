using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.coursera.org/learn/csharp-gaoji-biancheng/home
//c#高级编程

namespace Csharp_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.OutputEncoding = Encoding.Unicode;

            CsharpEX16.Program.Example16();
            //CsharpEX17.Program.Example17();
            Console.ForegroundColor = ConsoleColor.Magenta;
            //CsharpEX18.Program.Example18();
            //CsharpEX19.Program.Example19();
            CsharpEX20.Program.Example20();

            Console.ReadLine();
        }
    }
}

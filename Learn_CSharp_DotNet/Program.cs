using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Hiếu {0}", "Đẹp trai");

            PressEnterToEnd();
        }

        static void PressEnterToEnd()
        {
            Console.WriteLine("Ấn phím [ENTER] để kết thúc");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.Book.Session_1
{
    class Run
    {
        public static void Test()
        {
            //First();
            CodeSnippet_1();
        }

        static void First()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Hiếu {0}", "Đẹp trai");

            PressEnterToEnd();
        }

        static void CodeSnippet_1()
        {
            Console.WriteLine("This is a sample C# Program");
            Console.ReadLine();
        }

        #region Common Method

        static void PressEnterToEnd()
        {
            Console.WriteLine("Ấn phím [ENTER] để kết thúc");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        #endregion
    }
}

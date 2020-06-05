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

            //Book.Session_1.Run.Test();
            //Book.Session_3.Run.Test();
            Book.Session_4.Run.Test();

            PressEnterToEnd();
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

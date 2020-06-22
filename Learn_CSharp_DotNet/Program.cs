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

            // -> Book:
            //Book.Session_1.Run.Test();
            //Book.Session_3.Run.Test();
            //Book.Session_4.Run.Test();

            //Books.Session_6.Run.Test();


            /* -> CodeLean */
            //CodeLean.AP_06.Run.Test();
            //CodeLean.AP_07_08.Run.Test();
            //CodeLean.AP_09.Run.Test();
            //CodeLean.AP_10.Run.Test();
            //CodeLean.Lab_03.Run.Test();
            //CodeLean.AP_16.Run.Test();


            /* -> ExamPaper */
            ExamPaper.Run.Test();

            PressToEnd();
        }

        #region Common Method
        static void PressToEnd()
        {
            Console.WriteLine("\n\tẤn phím [ESC] để kết thúc");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
        #endregion
    }
}

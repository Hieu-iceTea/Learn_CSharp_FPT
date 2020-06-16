using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.Books.Session_6
{
    class Run
    {
        public static void Test()
        {
            //BaiTap_TrenLop();
            CodeSnippet_12();
        }

        private static void BaiTap_TrenLop()
        {
            var student = new Students();
            student.Display();

            student.printName(firstName: "đầu", lastName: "đít");
        }

        private static void CodeSnippet_12()
        {
            int numOne = 10;
            int numTwo = 20;

            Console.WriteLine("Before: {0} {1}", numOne, numTwo);

            Calculate(ref numOne, ref numTwo);

            Console.WriteLine("After: {0} {1}", numOne, numTwo);
        }

        private static void Calculate(ref int numOne, ref int numTwo)
        {
            numOne *= 2;
            numTwo /= 2;
        }
    }
}

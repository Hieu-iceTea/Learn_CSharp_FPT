using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.AP_13_15
{
    /// <summary>
    /// [AP_13] Xử lý Ngoại lệ trong C#
    /// http://codelean.vn/2020/05/ap13-xu-ly-ngoai-le-trong-c.html
    /// 
    /// [AP_15] Luyện Tập Exception Handling
    /// http://codelean.vn/2020/05/ap15-luyen-tap-exception-handling.html
    /// </summary>
    class Run
    {
        public static void Test()
        {
            int a = 10;
            int b = 0;

            if(b == 0)
            {
                //Console.WriteLine("Lỗi rồi thằng ngu");
                throw new Exception("Lỗi rồi thằng ngu");
            }

            int ketQua = a / b;
            return;
        }

        static int Divide(int first, int second)
        {
            int result = 0;
            try
            {
                result = first / second;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value");
            }

            return result;
        }
    }
}

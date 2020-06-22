using Learn_CSharp_DotNet.CodeLean.AP_07_08;
using Learn_CSharp_DotNet.CodeLean.AP_10_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.AP_12_14
{
    /// <summary>
    /// [AP_12] Phương Thức và Nạp Chồng
    /// https://www.codelean.vn/2020/05/ap12-phuong-thuc-va-nap-chong.html
    /// 
    /// [AP_14] Luyện Tập Nạp Chồng Phương Thức
    /// https://www.codelean.vn/2020/05/ap14-luyen-tap-nap-chong-phuong-thuc.html
    /// </summary>
    class Run
    {
        public static void Test()
        {
            var obj = new BusinessEmployee("Hieu");

            BusinessEmployee BE = new BusinessEmployee("Tu");


        }

        public static void Sum(int first, int second)
        {
            int sum = first + second;
            Console.WriteLine($"The sum of {first} and {second} is: {sum}");
        }

        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }

        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}

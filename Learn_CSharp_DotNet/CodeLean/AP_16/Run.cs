using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.AP_16
{
    /// <summary>
    /// https://www.codelean.vn/2020/05/ap16-gioi-thieu-ve-delegate-trong-c.html
    /// </summary>
    class Run
    {
        delegate int NumberChanger(int n);

        delegate double TinhLuong(double salary);

        public static void Test()
        {
            //Bai_1();
            Bai_2();

            //Bai_Test_TuLam();
        }

        private static void Bai_1()
        {
            //System.Delegate

            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
        }

        private static void Bai_2()
        {
            //create delegate instances
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            nc = nc1;
            nc += nc2;

            //calling multicast
            nc(5);
            Console.WriteLine("Value of Num: {0}", getNum());
        }

        private static void Bai_Test_TuLam()
        {
            TinhLuong tinhLuongSep = new TinhLuong(TinhLuong_Sep);
            TinhLuong tinhLuongNV = new TinhLuong(TinhLuong_NhanVien);

            double luongSep = tinhLuongSep(50);
            Console.WriteLine($"Luong sep la {luongSep}");

            Console.WriteLine($"Luong NV la {tinhLuongNV(30)}");
        }

        #region
        static int num = 10;
        
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        #endregion

        static double TinhLuong_Sep(double salary)
        {
            int baseSalary = 5;
            return salary * baseSalary;
        }

        static double TinhLuong_NhanVien(double salary)
        {
            int baseSalary = 2;
            return salary * baseSalary;
        }

    }
}

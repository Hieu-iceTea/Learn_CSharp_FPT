using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.ExamPaper
{
    class Run
    {
        public static void Test()
        {
            Product[] products = {
            new Book(01, "Tuoi tre dang gia bao nhieu", 50000, "Nha Xuat ban 1"),
            new Book(02, "Toi thay hoa vang tren co xanh", 88000, "Nha Xuat ban 2"),
            new Book(03, "HTML Basic", 65000, "Nha Xuat ban 3"),

            new MobilePhone(11, "iPhone X", 120000, "Apple"),
            new MobilePhone(12, "Samsung Note", 230000, "Samsung"),
            new MobilePhone(13, "LG Pro MAX", 280000, "LG")
            };

            double sumTax = 0;
            foreach (var item in products)
            {
                sumTax += item.computeTax();
            }

            Console.WriteLine($"Tổng thuế của 3 sách và 3 điện thoại là: {sumTax} vnđ");
        }
    }
}

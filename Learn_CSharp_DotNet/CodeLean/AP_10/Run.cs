using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.AP_10
{
    /// <summary>
    /// [AP_10] Tutorial Lab 1 - Inheritance
    /// https://www.codelean.vn/2020/05/ap10-tutorial-lab-1-inheritance.html
    /// 
    /// [AP_11] Tutorial Lab 2 - Abstract Class
    /// https://www.codelean.vn/2020/05/ap11-tutorial-lab-2-abstract-class.html
    /// </summary>
    class Run
    {
        public static void Test()
        {
            //Employee employee = new Employee("Nhân viên", 2000);
            TechnicalEmployee technicalEmployee = new TechnicalEmployee("Hiếu");
            BusinessEmployee businessEmployee = new BusinessEmployee("Sếp của Hiếu");

            //Console.WriteLine(employee.empoloyeeStatus());
            Console.WriteLine(technicalEmployee.empoloyeeStatus());
            Console.WriteLine(businessEmployee.empoloyeeStatus());
        }
    }
}

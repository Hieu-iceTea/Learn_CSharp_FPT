using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.Lab_03
{
    /// <summary>
    /// http://classroom.google.com/u/1/c/NTMyMDEzMzg3MDla/a/MTA5MzQ0ODU0MjA3
    /// </summary>
    class Run
    {
        public static void Test()
        {
            //Bai_1();
            //Bai_2();
            //Part_4_1();
            Part_4_2();
        }

        private static void Bai_1()
        {
            Car myCar = new Car();

            // assign values to the Car object's fields using myCar
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.yearBuilt = 1995;

            myCar.Start();
            myCar.Stop();
        }

        private static void Bai_2()
        {
            //Polimorphism

            Window window = new Window(1, 2);
            ListBox listBox = new ListBox(3, 4, "Stand alone list box");
            Button button = new Button(5, 6);

            window.DrawWindow();
            listBox.DrawWindow();
            button.DrawWindow();
        }

        private static void Part_4_1()
        {
            Console.WriteLine("Atomic Information");
            Console.WriteLine("==================");

            Atom atom = new Atom();
            atom.accept();

            Console.WriteLine("------------------------------------");
            atom.display();
        }

        private static void Part_4_2()
        {
            Employee employee = new Employee("Nguyễn", "Hiếu", "Ha Noi", 10, 9999);

            Console.WriteLine(employee);
        }
    }
}

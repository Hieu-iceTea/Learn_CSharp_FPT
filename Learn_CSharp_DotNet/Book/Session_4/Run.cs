using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.Book.Session_4
{
    class Run
    {
        public static void Test()
        {
            //CodeSnippet_1();
            //CodeSnippet_2();
            //CodeSnippet_3();
            //CodeSnippet_4();
            //CodeSnippet_5();
            //CodeSnippet_6();
        }

        private static void CodeSnippet_1()
        {
            int num = -4;
            if (num < 0)
            {
                Console.WriteLine("The number is negative");
            }
        }

        private static void CodeSnippet_2()
        {
            int num = 10;
            if (num < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is positive");
            }
        }

        private static void CodeSnippet_3()
        {
            int num = 13;
            if (num < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else if ((num % 2) == 0)
            {
                Console.WriteLine("The number is even");
            }
        }

        private static void CodeSnippet_4()
        {
            int yrsOfService = 3;
            double salary = 1500;
            int bonus = 0;
            if (yrsOfService < 5)
            {
                if (salary < 500)
                {
                    bonus = 100;
                }
                else
                {
                    bonus = 200;
                }
            }
            else
            {
                bonus = 700;
            }
            Console.WriteLine("Bonusamountz: " + bonus);
        }

        private static void CodeSnippet_5()
        {
            int day = 5;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Enter a number between 1 to 7");
                    break;
            }
        }

        private static void CodeSnippet_6()
        {
            int numOne;
            int numTwo;
            int choose;
            int result;

            Console.Write("Menu\n" +
                "1. Cộng\n" +
                "2. Trừ\n" +
                "3. Nhân\n" +
                "4. Chia\n" +
                "\tBạn chọn: ");
            choose = Convert.ToInt32(Console.ReadLine());

            Console.Write("numOne = ");
            numOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("numTwo = ");
            numTwo = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    result = numOne + numTwo;
                    break;
                case 2:
                    result = numOne - numTwo;
                    break;
                case 3:
                    result = numOne * numTwo;
                    break;
                case 4:
                    result = numOne / numTwo;
                    break;
                default:
                    throw new Exception("Nhập liệu không hợp lệ!");
                    //break;
            }

            Console.WriteLine("Kết quả: {0}", result);
        }
    }
}

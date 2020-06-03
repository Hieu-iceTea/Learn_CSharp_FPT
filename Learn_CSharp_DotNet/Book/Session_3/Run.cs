using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.Book.Session_3
{
    class Run
    {
        public static void Test()
        {
            CodeSnippet_1();
            CodeSnippet_2();
            CodeSnippet_3();
            CodeSnippet_4();
            CodeSnippet_5();
        }

        private static void CodeSnippet_1()
        {
            double radius = 10;
            double area = 3.1452 * radius * radius;
        }

        private static void CodeSnippet_2()
        {
            int side = 10;

            int height = 5;

            double area = 0.5 * side * height;
            Console.WriteLine("Area: ", area);
        }

        private static void CodeSnippet_3()
        {
            int side = 5;
            int height = 10;

            double area;
            area = 0.5 * side * height; 
            
            Console.WriteLine(area);
        }

        private static void CodeSnippet_4()
        {
            byte numOne = 255;
            byte numTwo = 1;
            byte result = 0;
            try
            {
                //Thiscodethrowsanoverflowexception
                checked
                {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Result:" + result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void CodeSnippet_5()
        {
            byte numOne = 255;
            byte numTwo = 1;
            byte result = 0;
            try
            {
                //Thiscodethrowsanoverflowexception
                unchecked
                {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Result:" + result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void CodeSnippet_6()
        {
            //simpleInterest = principal * time * rate / 100;
            //eval = 25 + 6 - 78 * 5;
            //num++;
        }

        private static void CodeSnippet_7()
        {
            int valueOne = 10;

            int valueTwo = 2;

            int add = valueOne + valueTwo;

            int sub = valueOne - valueTwo;

            int mult = valueOne * valueTwo;

            int div = valueOne / valueTwo;

            int modu = valueOne % valueTwo;

            Console.WriteLine("Addition " + add);
            Console.WriteLine("Subtraction " + sub);
            Console.WriteLine("Multiplication " + mult);
            Console.WriteLine("Division " + div);
            Console.WriteLine("Remainder " + modu);
        }

        private static void CodeSnippet_8()
        {
            int leftVal = 50;

            int rightVal = 100;

            Console.WriteLine("Equal: " + (leftVal == rightVal));
            Console.WriteLine("Not Equal: " + (leftVal != rightVal));
            Console.WriteLine("Greater: " + (leftVal > rightVal));

            Console.WriteLine("Lesser: " + (leftVal < rightVal));

            Console.WriteLine("Greater or Equal: " + (leftVal >= rightVal));
            Console.WriteLine("Lesser or Equal: " + (leftVal <= rightVal));
        }
    }
}

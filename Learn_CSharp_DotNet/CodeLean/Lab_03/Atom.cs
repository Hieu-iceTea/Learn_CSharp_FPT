using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.Lab_03
{
    class Atom
    {
        private int number;
        private string symbol;
        private string fullName;
        private float weight;

        public void accept()
        {
            Console.Write("Enter atomic number: ");
            //this.number = Convert.ToInt32(Console.ReadLine());
            if (!Int32.TryParse(Console.ReadLine(), out this.number))
                return;

            Console.Write("Enter symbol: ");
            this.symbol = Console.ReadLine();

            Console.Write("Enter full name: ");
            this.fullName = Console.ReadLine();

            Console.Write("Enter atomic weight: ");
            //this.weight = float.Parse(Console.ReadLine());
            if (!float.TryParse(Console.ReadLine(), out this.weight))
                return;
        }

        public void display()
        {
            Console.WriteLine(number + " " + symbol + " " + fullName + " " + weight);
        }
    }
}

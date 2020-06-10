using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.AP_06
{
    class Run
    {
        public static void Test()
        {
            DrinksMachine drinksMachine = new DrinksMachine();
            drinksMachine.MakeEspresso();
            drinksMachine.MakeCappuccino();
        }
    }

    partial class DrinksMachine
    {
        public void MakeCappuccino()
        {
            // Method logic goes here.
            Console.WriteLine("-> MakeCappuccino");
        }
    }
}

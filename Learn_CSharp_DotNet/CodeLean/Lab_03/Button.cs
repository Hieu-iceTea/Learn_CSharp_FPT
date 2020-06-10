using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.Lab_03
{
    class Button : Window
    {
        public Button(int top, int left) : base(top, left)
        {
            //Notthing
        }

        public override void DrawWindow()
        {
            //base.DrawWindow();
            Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
        }
    }
}

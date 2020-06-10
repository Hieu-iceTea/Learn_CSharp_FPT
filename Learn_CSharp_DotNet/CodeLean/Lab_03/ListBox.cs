using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.Lab_03
{
    class ListBox : Window
    {
        private string listBoxContents;

        public ListBox(int top, int left, string listBoxContents) : base(top, left)
        {
            this.listBoxContents = listBoxContents;
        }

        public override void DrawWindow()
        {
            //base.DrawWindow();
            Console.WriteLine("Writing string to the listbox:{0}", listBoxContents);
        }
    }
}

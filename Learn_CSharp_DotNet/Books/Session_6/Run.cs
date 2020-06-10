using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.Books.Session_6
{
    class Run
    {
        public static void Test()
        {
            var student = new Students();
            student.Display();

            student.printName(firstName: "đầu", lastName: "đít");
        }
    }
}

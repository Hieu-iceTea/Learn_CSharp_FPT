using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.AP_09
{
    /// <summary>
    /// [AP_09] Interface trong C# 
    /// https://www.codelean.vn/2020/05/ap09-interface-trong-c.html
    /// </summary>
    class Run
    {
        public static void Test()
        {
            Customer customer = new Customer();

            Coffee coffee = new Coffee();


            IBeverage beverage = new Coffee();
            
            IBeverage beverage2 = coffee;
            Coffee coffee2 = beverage2 as Coffee;
        }
    }
}

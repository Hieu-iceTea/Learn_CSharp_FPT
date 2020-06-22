using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.AP_10_11
{
    class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;

        public TechnicalEmployee(string name) : base(name, 75000)
        {
            //notthing
        }

        public override string empoloyeeStatus()
        {
            return base.ToString() + " có " + successfulCheckIns + " lần đăng ký thành công";
        }
    }
}

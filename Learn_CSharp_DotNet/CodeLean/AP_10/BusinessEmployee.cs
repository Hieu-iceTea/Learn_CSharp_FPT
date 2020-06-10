using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.AP_10
{
    class BusinessEmployee : Employee
    {
        public double bonusBudget = 1000;

        public BusinessEmployee(string name) : base(name, 50000)
        {
            //notthing
        }

        public override string empoloyeeStatus()
        {
            return base.ToString() + " với ngân sách " + this.bonusBudget;
        }
    }
}

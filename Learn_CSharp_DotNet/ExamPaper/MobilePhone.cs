using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.ExamPaper
{
    class MobilePhone : Product
    {
        public MobilePhone(int productId, string name, double price, string producer) 
            : base(productId, name, price, producer)
        {
            //nothing
        }

        public override double computeTax()
        {
            return base.Price * 0.1;
        }
    }
}

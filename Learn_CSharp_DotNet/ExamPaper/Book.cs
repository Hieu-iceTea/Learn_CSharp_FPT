using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.ExamPaper
{
    class Book : Product
    {
        public Book(int productId, string name, double price, string producer) 
            : base(productId, name, price, producer)
        {
            //nothing
        }

        public override double computeTax()
        {
            return base.Price * 0.08;
        }
    }
}

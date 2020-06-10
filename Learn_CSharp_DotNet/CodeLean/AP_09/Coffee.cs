using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.AP_09
{
    class Coffee : IBeverage
    {
        private int servingTempWithoutMilk { get; set; }
        private int servingTempWithMilk { get; set; }

        int IBeverage.GetServingTemperature(bool includesMilk)
        {
            if (includesMilk)
            {
                return servingTempWithMilk;
            }
            else
            {
                return servingTempWithoutMilk;
            }
        }

        bool IBeverage.IsFairTrade { get; set; }

        string IBeverage.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        event EventHandler IBeverage.OnSoldOut
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.AP_09
{
    interface IBeverage
    {
        /* Methods, properties, events, and indexers go here. */

        //Để xác định một phương thức, bạn chỉ định tên của phương thức, kiểu trả về và bất kỳ tham số nào:
        int GetServingTemperature(bool includesMilk);

        //Để xác định một thuộc tính, bạn chỉ định tên của thuộc tính, thuộc tính và property accessors:
        bool IsFairTrade { get; set; }

        //Để xác định một thuộc tính, bạn chỉ định tên của thuộc tính, thuộc tính và property accessors:
        event EventHandler OnSoldOut;

        //Để xác định một bộ chỉ mục, bạn chỉ định loại trả về và access modifiers:
        string this[int index] { get; set; }
    }
}

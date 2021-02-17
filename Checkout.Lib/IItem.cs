using System;
using System.Collections.Generic;
using System.Text;

namespace Checkout.Lib
{
    interface IItem
    {
        char SKU { get; }
        double UnitPrice { get; }
    }
}

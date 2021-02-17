using System;
using System.Collections.Generic;
using System.Text;

namespace Checkout.Lib
{
    public interface IItem
    {
        char SKU { get; }
        double UnitPrice { get; }
    }
}

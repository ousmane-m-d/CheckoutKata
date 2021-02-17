using System;
using System.Collections.Generic;
using System.Text;

namespace Checkout.Lib
{
    interface IBasket
    {
        public void AddItem(Item item);
        double TotalCost { get; }
    }
}

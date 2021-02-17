using System;

namespace Checkout.Lib
{
    public class Item : IItem
    {
        public char SKU { get; }
        public double UnitPrice { get; }

        public Item(char sku, double unitPrice)
        {
            SKU = sku;
            UnitPrice = unitPrice;
        }
    }
}

using System;

namespace Checkout.Lib
{
    public class Item : IItem
    {
        public char SKU { get; }
        public double UnitPrice { get; }

        public Item(char sku, double unitPrice)
        {
            if (unitPrice <= 0)
            {
                throw new ArgumentException(message: "item price cannot be than or equal to 0", paramName: nameof(unitPrice));
            }

            SKU = sku;

            UnitPrice = unitPrice;
        }
    }
}

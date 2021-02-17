using System;

namespace Checkout.Lib
{
    public class Item : IItem
    {    
        public Item(char sku, double unitPrice)
        {
            if (unitPrice <= 0)
            {
                throw new ArgumentException(message: "item price cannot be less than or equal to 0", paramName: nameof(unitPrice));
            }

            SKU = sku;

            UnitPrice = unitPrice;
        }

        public char SKU { get; }

        public double UnitPrice { get; }
    }
}

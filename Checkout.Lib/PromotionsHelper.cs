using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkout.Lib
{
    public static class PromotionsHelper
    {
        public static double CalculateCost(List<Item> items)
        {
            if (items.Count == 0) return 0;

            switch (items[0].SKU)
            {
                case 'B' when items.Count >= 3:
                    {
                        var amountOfDiscounts = items.Count / 3;
                        var amountAfterDiscount = amountOfDiscounts * 40;

                        var itemsNotNeedingDiscount = items.Count % 3;

                        return itemsNotNeedingDiscount * items[0].UnitPrice + amountAfterDiscount;
                    }

                case 'D' when items.Count >= 2:
                    return 0;
            }

            return items.Sum(item => item.UnitPrice);
        }
    }
}

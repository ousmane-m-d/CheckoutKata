using System.Collections.Generic;
using System.Linq;

namespace Checkout.Lib
{
    /*
     * Due to the time constraints of this Task i.e. it being done between 1-2 hours I did not manage to refactor this logic.
     * If I had more time I would probably have deleted this file and instead created a IPromotion interface with a Promotion 
     * class implementing that and then this would be used in Item instances to dictate whether a promotion should be 
     * applied or not.
     */
    public static class PromotionsHelper
    {
        public static double CalculateCost(List<IItem> items)
        {
            if (items.Count == 0) return 0;

            switch (items[0].SKU)
            {
                case 'B' when items.Count >= 3:
                    {
                        var numberOfDiscounts = items.Count / 3;
                        var amountAfterDiscount = numberOfDiscounts * 40;

                        var numberOfItemsNotNeedingDiscount = items.Count % 3;

                        return numberOfItemsNotNeedingDiscount * items[0].UnitPrice + amountAfterDiscount;
                    }

                case 'D' when items.Count >= 2:
                    {
                        var numberOfDiscounts = items.Count / 2;
                        var promotionApplied = (items[0].UnitPrice * 2) * 0.75;
                        var numberOfItemsNotNeedingDiscount = items.Count % 2;

                        return (numberOfItemsNotNeedingDiscount * items[0].UnitPrice) + (promotionApplied * numberOfDiscounts);
                    }
            }

            return items.Sum(item => item.UnitPrice);
        }
    }
}

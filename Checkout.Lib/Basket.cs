using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkout.Lib
{
    public class Basket : IBasket
    {
        private readonly Dictionary<char, List<Item>> _skuToItems;

        public Basket() => _skuToItems = new Dictionary<char, List<Item>>();

        public void AddItem(Item item)
        {
            if (!_skuToItems.ContainsKey(item.SKU))
            {
                _skuToItems[item.SKU] = new List<Item>();
            }

            _skuToItems[item.SKU].Add(item);
        }

        public double TotalCost => _skuToItems.Values.Sum(items => PromotionsHelper.CalculateCost(items));

        public int ItemsCount => _skuToItems.Values.Sum(items => items.Count);
    }
}

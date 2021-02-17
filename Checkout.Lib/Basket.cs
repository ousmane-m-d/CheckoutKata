using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkout.Lib
{
    public class Basket : IBasket
    {
        private readonly List<Item> _items;

        public Basket()
        {
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public int ItemsCount => _items.Count;

        public double TotalCost => _items.Sum(item => item.UnitPrice);
    }
}

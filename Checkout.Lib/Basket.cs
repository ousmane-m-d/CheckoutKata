using System;
using System.Collections.Generic;

namespace Checkout.Lib
{
    public class Basket
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
    }
}

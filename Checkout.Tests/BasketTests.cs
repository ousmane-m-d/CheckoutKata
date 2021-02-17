using Checkout.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Checkout.Tests
{
    [TestClass]
    public class BasketTests
    {
        [TestMethod]
        public void Given_IHaveSelectedToAddAnItemToTheBasket_ThenTheItemShouldBeAddedToTheBasket()
        {
            // Arrange
            var basket = new Basket();
            var item = new Item();

            // Act
            basket.AddItem(item);

            // Assert
            Assert.AreEqual(expected: 1, actual: basket.ItemsCount);
        }

        [TestMethod]
        public void Given_ItemsHaveBeenAddedToTheBasket_ThenTheTotalCostOfTheBasketShouldBeCalculated()
        {
            // Arrange
            var basket = new Basket();
            var itemA = new Item('A', 10);
            var itemB = new Item('B', 15);
            var itemC = new Item('C', 40);
            var itemD = new Item('D', 55);

            // Act
            basket.AddItem(itemA);
            basket.AddItem(itemB);
            basket.AddItem(itemC);
            basket.AddItem(itemD);

            // Assert
            Assert.AreEqual(expected: 120, actual: basket.TotalCost);
        }
    }
}

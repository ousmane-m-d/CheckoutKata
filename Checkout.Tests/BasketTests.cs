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
            var item = new Item(sku: 'A', unitPrice: 10);

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
            var itemA = new Item(sku: 'A', unitPrice: 10);
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

        [DataTestMethod]
        [DataRow(1, 15)]
        [DataRow(2, 30)]
        [DataRow(3, 40)]
        [DataRow(4, 55)]
        [DataRow(5, 70)]
        [DataRow(6, 80)]
        public void Given_IHaveAddedAMultipleOfThreeLotsOfItemBToTheBasketThenAPromotionOfThreeForFourthyShouldBeAppliedToEveryMultipleOfThree(int numberOfItems, double expectedTotalCost)
        {
            // Arrange
            var basket = new Basket();

            // Act
            for (int i = 0; i < numberOfItems; i++) {
                basket.AddItem(new Item(sku: 'B', unitPrice: 15));
            }

            // Assert
            Assert.AreEqual(expectedTotalCost, basket.TotalCost);
        }


        [DataTestMethod]
        [DataRow(1, 55)]
        [DataRow(2, 82.5)]
        [DataRow(3, 137.5)]
        [DataRow(4, 165)]
        [DataRow(5, 220)]
        [DataRow(6, 247.5)]
        public void Given_IHaveAddedAMultipleOfTwoLotsOfItemDToTheBasketThenAPromotionOfTwentyFivePercentOffShouldBeAppliedToEveryMultipleOfTwo(int numberOfItems, double expectedTotalCost)
        {
            // Arrange
            var basket = new Basket();

            // Act
            for (int i = 0; i < numberOfItems; i++)
            {
                basket.AddItem(new Item(sku: 'D', unitPrice: 55));
            }

            // Assert
            Assert.AreEqual(expectedTotalCost, basket.TotalCost);
        }
    }
}

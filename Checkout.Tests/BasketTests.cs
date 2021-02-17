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
    }
}

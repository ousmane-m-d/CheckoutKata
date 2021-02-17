namespace Checkout.Lib
{
    public interface IBasket
    {
        public void AddItem(IItem item);

        double TotalCost { get; }
    }
}

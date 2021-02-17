namespace Checkout.Lib
{
    public interface IItem
    {
        char SKU { get; }

        double UnitPrice { get; }
    }
}

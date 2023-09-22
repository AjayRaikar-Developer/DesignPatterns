namespace DesignPatterns.Structural_Patterns.Facade.ShoppingCart.Interfaces
{
    public interface IOrder
    {
        int PlaceOrderDetails(int cartID, int shippingAddressID);
    }
}

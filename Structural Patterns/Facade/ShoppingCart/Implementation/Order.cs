using DesignPatterns.Structural_Patterns.Facade.ShoppingCart.Interfaces;

namespace DesignPatterns.Structural_Patterns.Facade.ShoppingCart.Implementation
{
    public class Order : IOrder
    {
        public int PlaceOrderDetails(int cartID, int shippingAddressID)
        {
            Console.WriteLine("\t SubSystem Order : PlaceOrderDetails");
            return 10;
        }
    }
}

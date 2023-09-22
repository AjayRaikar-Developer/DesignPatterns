using DesignPatterns.Structural_Patterns.Facade.ShoppingCart.Models;

namespace DesignPatterns.Structural_Patterns.Facade.ShoppingCart.Interfaces
{
    public interface ICart
    {
        Product GetItemDetails(int itemID);
        bool CheckItemAvailability(Product product);
        bool LockItemInStock(int itemID, int quantity);
        int AddItemToCart(int itemID, int quantity);
        double GetCartPrice(int cartID);
    }
}

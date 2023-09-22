using DesignPatterns.Structural_Patterns.Facade.ShoppingCart.Models;

namespace DesignPatterns.Structural_Patterns.Facade.ShoppingCart.Interfaces
{
    public interface IAddresses
    {
        Address GetAddressDetails(int userID);
    }
}

using DesignPatterns.Structural_Patterns.Facade.ShoppingCart.Interfaces;

namespace DesignPatterns.Structural_Patterns.Facade.ShoppingCart.Implementation
{
    public class Wallet : IWallet
    {
        public double GetUserBalance(int userID)
        {
            Console.WriteLine("\t SubSystem Wallet : GetUserBalance");
            return 100;
        }
    }
}

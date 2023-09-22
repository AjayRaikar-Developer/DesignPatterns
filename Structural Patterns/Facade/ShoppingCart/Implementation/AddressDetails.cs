using DesignPatterns.Structural_Patterns.Facade.ShoppingCart.Interfaces;
using DesignPatterns.Structural_Patterns.Facade.ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Facade.ShoppingCart.Implementation
{
    public class AddressDetails : IAddresses
    {
        public Address GetAddressDetails(int userID)
        {
            Console.WriteLine("\t SubSystem Address : GetAddressDetails");
            return new Address();
        }

    }
}

using DesignPatterns.Structural_Patterns.Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Bridge.Abstraction
{
    /// <summary>
    /// Abstraction 
    /// </summary>
    public abstract class Payment
    {
        public IPaymentSystem _IPaymentSystem;
        public abstract void MakePayment();
    }
}

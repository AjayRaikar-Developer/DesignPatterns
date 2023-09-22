using DesignPatterns.Structural_Patterns.Bridge.Implementor;

namespace DesignPatterns.Structural_Patterns.Bridge.ConcreteImplementor
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class IDBIPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using IDBIBank gateway for " + paymentSystem);
        }
    }
}

namespace DesignPatterns.Structural_Patterns.Bridge.Implementor
{
    /// <summary>
    /// Implementor Interface
    /// </summary>
    public interface IPaymentSystem
    {
        void ProcessPayment(string paymentSystem);
    }
}

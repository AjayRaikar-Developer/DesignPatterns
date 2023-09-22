using DesignPatterns.Structural_Patterns.Bridge.Abstraction;

namespace DesignPatterns.Structural_Patterns.Bridge.RefinedAbstraction
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class NetBankingPayment : Payment
    {
        public override void MakePayment()
        {
            _IPaymentSystem.ProcessPayment("NetBanking Payment");
        }
    }
}

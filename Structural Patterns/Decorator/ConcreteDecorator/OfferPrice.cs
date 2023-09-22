using DesignPatterns.Structural_Patterns.Decorator.Component;

namespace DesignPatterns.Structural_Patterns.Decorator.ConcreteDecorator
{
    public class OfferPrice : CarDecorator
    {
        public OfferPrice(ICar car) : base(car)
        {
        }
        public override double GetDiscountedPrice()
        {
            return .8 * base.GetPrice();
        }
    }
}

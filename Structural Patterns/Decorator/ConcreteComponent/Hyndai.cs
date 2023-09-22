using DesignPatterns.Structural_Patterns.Decorator.Component;

namespace DesignPatterns.Structural_Patterns.Decorator.ConcreteComponent
{
    public sealed class Hyndai : ICar
    {
        public string Make
        {
            get { return "HatchBack"; }
        }
        public double GetPrice()
        {
            return 800000;
        }
    }
}

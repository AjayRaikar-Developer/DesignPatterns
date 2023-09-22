using DesignPatterns.Structural_Patterns.Decorator.Component;

namespace DesignPatterns.Structural_Patterns.Decorator.ConcreteComponent
{
    public sealed class Suzuki : ICar
    {
        public string Make
        {
            get { return "Sedan"; }
        }
        public double GetPrice()
        {
            return 1000000;
        }
    }
}

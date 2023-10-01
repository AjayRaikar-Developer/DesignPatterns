namespace DesignPatterns.Behavioral_Patterns.Strategy.With_Strategy
{
    public class GoodsCar : VehicleManager
    {
        public GoodsCar() : base(new NormalDriverStrategy()) { }
    }
}

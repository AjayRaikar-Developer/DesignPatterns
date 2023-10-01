namespace DesignPatterns.Behavioral_Patterns.Strategy.With_Strategy
{
    public class SportsCar : VehicleManager
    {
        public SportsCar() : base(new SportsDriveStrategy()) { }
    }
}

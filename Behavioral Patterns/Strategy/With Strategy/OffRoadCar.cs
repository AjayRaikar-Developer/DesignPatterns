namespace DesignPatterns.Behavioral_Patterns.Strategy.With_Strategy
{
    public class OffRoadCar : VehicleManager
    {
        public OffRoadCar() : base(new SportsDriveStrategy()) { }
    }
}

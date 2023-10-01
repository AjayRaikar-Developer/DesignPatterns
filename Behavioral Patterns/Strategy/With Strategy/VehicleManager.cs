namespace DesignPatterns.Behavioral_Patterns.Strategy.With_Strategy
{
    public class VehicleManager
    {
        IDriveStrategy _strategy;
        public VehicleManager(IDriveStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void Drive()
        {
            _strategy.Drive();
        }
    }
}

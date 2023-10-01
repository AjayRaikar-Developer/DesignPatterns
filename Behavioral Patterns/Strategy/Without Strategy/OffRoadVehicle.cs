using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Strategy.Without_Strategy
{
    /// <summary>
    /// This Class & SportsVehicle class does the same task
    /// as both want Sports Drive Capability
    /// But its duplicating the work
    /// </summary>
    public class OffRoadVehicle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Sports Drive Capability");
        }
    }
}

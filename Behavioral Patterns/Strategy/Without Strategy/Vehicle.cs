using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Strategy.Without_Strategy
{
    public class Vehicle
    {
        public Vehicle()
        {

        }

        public virtual void Drive()
        {
            Console.WriteLine("Normal Drive Capability");
        }
    }
}

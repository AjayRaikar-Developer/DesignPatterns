using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Strategy.With_Strategy
{
    public class NormalDriverStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("Normal Drive Capability");
        }
    }
}

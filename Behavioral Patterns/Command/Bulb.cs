using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Command
{
    public class Bulb
    {
        bool isOn;

        public void turnOnBulb()
        {
            isOn = true;
            Console.WriteLine("Blub turned on");
        }

        public void turnOffBulb()
        {
            isOn = false;
            Console.WriteLine("Bulb turned off");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Command
{
    public class AirConditioner
    {
        bool isOn;
        int temperature;

        public void turnOnAc()
        {
            isOn = true;
            Console.WriteLine("AC turned on");
        }

        public void turnOffAc()
        {
            isOn = false;
            Console.WriteLine("AC turned off");
        }

        public void setTemperature(int temp)
        {
            temperature = temp;
            Console.WriteLine($"AC temperature changed to: {temp}");
        }

    }
}

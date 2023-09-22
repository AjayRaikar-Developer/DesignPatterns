using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Flyweight.GameModels
{
    public class DogRobo : IRobot
    {
        //Intrinsic Properties : Shared among objects and remain same once defined one value
        private string Type { get; set; }
        private object Body { get; set; }

        public DogRobo(string type, object body)
        {
            Type = type;
            Body = body;
        }

        public string Get_Type()
        {
            return Type;
        }

        public object GetBody()
        {
            return Body;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"DogRobo Co-Ordinates X:{x}, Y:{y}");
        }
    }
}

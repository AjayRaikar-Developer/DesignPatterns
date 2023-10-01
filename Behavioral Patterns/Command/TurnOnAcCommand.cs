using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Command
{
    public class TurnOnAcCommand : ICommand
    {
        AirConditioner _ac;
        public TurnOnAcCommand(AirConditioner ac) {
            _ac = ac;
        }
        public void Execute()
        {
            _ac.turnOnAc();
        }

        public void Undo()
        {
            _ac.turnOffAc();
        }
    }
}

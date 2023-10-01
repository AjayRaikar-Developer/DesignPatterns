using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Command
{
    public class TurnOffAcCommand : ICommand
    {
        AirConditioner _ac;
        public TurnOffAcCommand(AirConditioner ac) {
            _ac = ac;
        }
        public void Execute()
        {
            _ac.turnOffAc();
        }

        public void Undo()
        {
            _ac.turnOnAc();
        }
    }
}

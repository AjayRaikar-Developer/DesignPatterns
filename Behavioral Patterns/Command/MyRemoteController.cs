using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Command
{
    public class MyRemoteController
    {
        Stack<ICommand> _acCommandsHistory = new Stack<ICommand>();
        ICommand _command;
        public MyRemoteController() { }

        public void setCommand(ICommand command)
        {
            this._command = command;
            this._acCommandsHistory.Push(this._command);
        }

        public void pressButton()
        {
            _command.Execute();
        }

        public void undo()
        {
            if(this._acCommandsHistory.Count > 0)
            {
                ICommand lastCommand = this._acCommandsHistory.Pop();
                lastCommand.Undo();
            }
        }
    }
}

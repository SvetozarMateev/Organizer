using System;
using System.Collections.Generic;
using TODO.Engine;

namespace TODO.Commands
{
    public class LogOutCommand : Command, ICommand
    {
        public LogOutCommand(List<string> parameters)
            : base(parameters)
        {
        }

        public override string Execute
        {
            get
            {
                EngineMaikaTI.loggedUser = null;
                return $"Successfully logged Out";
            }
        }
    }
}

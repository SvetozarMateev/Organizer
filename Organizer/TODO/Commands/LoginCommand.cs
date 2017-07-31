using System;
using System.Collections.Generic;
using TODO.Engine;

namespace TODO.Commands
{
    public class LoginCommand : Command, ICommand
    {
        // private List<string> usernames=
        public LoginCommand(List<string> input)
            : base(input)
        {

        }

        public override string Execute()
        {
            string username = base.Parameters[1];
            string password = base.Parameters[2];
            // if()
            return "";
        }
    }
}

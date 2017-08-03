using System;
using System.Collections.Generic;
using TODO.Engine;

namespace TODO.Commands
{
    public class RegisterCommand : Command, ICommand
    {
        public RegisterCommand(List<string> parameters)
            : base(parameters)
        {

        }

        public override string Execute
        {
            get
            {
                string username = base.Parameters[1];
                string password = base.Parameters[2];
                EngineMaikaTI.loggedUser = base.factory.CreateUser(username, password);
                Saver.SaveUsernamesAndPasswords(username,password);
                return $"User created: {username}";
            }
        }
    }
}

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

        public override string Execute()
        {
            string username = base.Parameters[1];
            string password = base.Parameters[2];
            EngineMaikaTI.loggedUser = base.factory.CreateUser(username, password);
            Saver.SaveUsernames(username);
            return $"User created: {username}";
        }


    }
}

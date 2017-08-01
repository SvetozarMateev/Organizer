using System;
using System.Collections.Generic;
using TODO.Engine;

namespace TODO.Commands
{
    public class LoginCommand : Command, ICommand
    {
        private List<string> usernamesAndPasswords = Loader.LoadUsernamesAndPasswords();

        public LoginCommand(List<string> input)
            : base(input)
        {
        }

        public override string Execute
        {
            get
            {
                string username = base.Parameters[1];
                string password = base.Parameters[2];

                if (CheckCredentials(username, password))
                {
                    // TODO: (**only if there isn't already a user) traverse file directory for the database of the username and
                    // create a new user with everything in his database.txt :D + change loggedUser
                    return "Successfully logged !" + " but not implemented yet";
                }
                return "Wrong Credentials";
            }
        }

        private bool CheckCredentials(string inputUsername, string inputPassword)
        {
            foreach (var userAndPass in this.usernamesAndPasswords)
            {
                string username = userAndPass.Split()[0];
                string password = userAndPass.Split()[1];
                if (username == inputUsername && password == inputPassword)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

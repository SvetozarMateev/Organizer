using System;
using System.Collections.Generic;
using TODO.Contracts;
using TODO.Models;

namespace TODO.Factories
{
    public class OrganizerFactory : IOrganizerFactory
    {
        public IUser CreateUser(string username, string password)
        {
            return new User(username, password);
        }
    }
}

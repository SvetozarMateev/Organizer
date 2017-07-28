

using System;
using System.Collections.Generic;
using TODO.Contracts;

namespace TODO.Models
{
    public class User : IUser
    {
        public ICollection<INotebook> Notebook
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Password
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Username
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void AddNotebook()
        {
            throw new NotImplementedException();
        }

        public void DeleteNotebook()
        {
            throw new NotImplementedException();
        }
    }
}

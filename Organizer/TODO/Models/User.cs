

using System;
using System.Collections.Generic;
using TODO.Contracts;
using TODO.Utils.GlobalConstants;
using TODO.Utils.Validator;

namespace TODO.Models
{
    public class User : IUser
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            this.Username = Username;
            this.Password = password;
        }

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
                return this.password;
            }
            private set
            {
                Validator.CheckPasswordStrength(value);

                this.password = value;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                Validator.CannotBeNull(value);
                Validator.CheckNameLength(value, Constants.MinUserLength);
                Validator.CheckUserName(value);

                this.username = value;
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

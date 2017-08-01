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
        private ICollection<INotebook> notebooks;

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.Notebooks = new List<INotebook>();
        }

        public ICollection<INotebook> Notebooks
        {
            get
            {
                return this.notebooks;
            }
            private set
            {
                this.notebooks = value;
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
                Validator.CannotBeNullOrEmpty(value);
                Validator.CheckNameLength(value, Constants.MinUserLength);
                Validator.CheckUserName(value);

                this.username = value;
            }
        }

        public void AddNotebook(INotebook notebook)
        {
            this.notebooks.Add(notebook);
        }
        public void DeleteNotebook()
        {
            throw new NotImplementedException();
        }
        public void Sort()
        {

        }
        public string FormatUserInfoForDB()
        {
            return $"{this.Username} {this.Password}" + Environment.NewLine +
                $"{string.Join("\n-----", this.Notebooks)}";  // for now 
        }
    }
}

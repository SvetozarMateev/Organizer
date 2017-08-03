using System;
using System.Collections.Generic;
using System.Linq;
using TODO.Contracts;
using TODO.Utils.GlobalConstants;
using TODO.Utils.Validator;

namespace TODO.Models
{
    public class User : IUser, ISaveable
    {
        private string username;
        private string password;
        private ICollection<INotebook> notebooks;
        private ICollection<ITask> tasks;

        public User(string username, string password, ICollection<INotebook> notebooks = null, ICollection<ITask> tasks = null)
        {
            this.Username = username;
            this.Password = password;
            this.Notebooks = notebooks;
            this.Tasks = tasks;
        }

        public ICollection<INotebook> Notebooks
        {
            get
            {
                return this.notebooks;
            }
            private set
            {
                if (value == null)
                {
                    this.notebooks = new List<INotebook>();
                }
                else
                {
                    this.notebooks = value;

                }
            }
        }

        public ICollection<ITask> Tasks
        {
            get
            {
                return this.tasks;
            }
            private set
            {
                if (value != null)
                {
                    this.tasks = value;
                }
                else
                {
                    this.tasks = new List<ITask>();
                }

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
        public void AddTask(ITask task)
        {
            this.Tasks.Add(task);
        }
        public void Sort()
        {

        }
        public string FormatUserInfoForDB()
        {
            return $"{this.Username} {this.Password}" +
                $"{(this.Notebooks.Count == 0 ? string.Empty : Environment.NewLine + string.Join(Environment.NewLine, this.Notebooks.Select(x => x.FormatUserInfoForDB())))}"
                + Environment.NewLine + "---***---"
                + $"{(this.Tasks.Count == 0 ? string.Empty : Environment.NewLine + string.Join(Environment.NewLine, this.Tasks.Select(x => x.FormatUserInfoForDB())))}"
                 + Environment.NewLine + "___***___" + Environment.NewLine;
        }
    }
}

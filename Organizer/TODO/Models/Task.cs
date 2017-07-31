

using System;
using TODO.Contracts;
using TODO.Models;
using TODO.Utils.GlobalConstants;
using TODO.Utils.Validator;

namespace TODO
{
    public class Task : ITask
    {
        private IUser author;


        public IUser Author
        {
            get
            {
                return this.author;
            }
            private set
            {
                // TODO validations
                this.author = value;
            }

        }

        public string Description
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Priority Priority
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        
        public IReminder Reminder
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public DateTime Start
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public TaskType TaskType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Title
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}

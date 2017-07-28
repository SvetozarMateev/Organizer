

using System;
using TODO.Contracts;
using TODO.Models;

namespace TODO
{
    public class Task : ITask
    {
        public IUser Author
        {
            get
            {
                throw new NotImplementedException();
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

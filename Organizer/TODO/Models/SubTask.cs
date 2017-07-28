

using System;
using TODO.Contracts;

namespace TODO.Models
{
    public class SubTask : Task, ITask ,ISubTask
    {
        public IUser Author
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Content
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

        public DateTime DueDate
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public double ImportancePercent
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

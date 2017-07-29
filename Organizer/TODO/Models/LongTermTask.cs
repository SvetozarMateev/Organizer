

using System;
using System.Collections.Generic;
using TODO.Contracts;
using TODO.Models;
using TODO.Utils.Validator;

namespace TODO.Models
{
    public class LongTermTask : Task, ITask,ILongTermTask
    {
        public ICollection<SubTask> AllTasks
        {
            get
            {
                throw new NotImplementedException();
            }
        }

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

        public DateTime End
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

        public void AddSubTask(SubTask subTask)
        {
            throw new NotImplementedException();
        }

        public void CalculateDefaultPriorityOfAll()
        {
            throw new NotImplementedException();
        }
    }
}

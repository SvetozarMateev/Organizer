using System;
using System.Collections.Generic;
using TODO.Contracts;
using TODO.Models;
using TODO.Utils.Validator;

namespace TODO.Models
{
    public class LongTermTask : Task, ITask, ILongTermTask
    {
        public ICollection<SubTask> AllTasks
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

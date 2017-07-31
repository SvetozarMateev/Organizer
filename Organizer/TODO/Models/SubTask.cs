using System;
using TODO.Contracts;

namespace TODO.Models
{
    public class SubTask : Task, ITask, ISubTask
    {
        public string Content
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
    }
}

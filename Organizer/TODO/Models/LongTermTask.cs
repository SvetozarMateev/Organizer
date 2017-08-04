using System;
using System.Collections.Generic;
using TODO.Contracts;
using TODO.Utils.Validator;

namespace TODO.Models
{
    public class LongTermTask : Task, ITask, ILongTermTask,ISaveable
    {
        private ICollection<ISubTask> allTasks;
        private DateTime end;

        public LongTermTask(string title, Priority priority, string description , DateTime end, DateTime start=default(DateTime)  )
            : base(title, priority, description,start)
        {
            this.End = end;
            this.AllTasks = new List<ISubTask>();
        }


        public ICollection<ISubTask> AllTasks
        {
            get
            {
                return this.allTasks;
            }
            private set
            {
                Validator.CollectionCannotBeNull(value);

                this.allTasks = value;
            }
        }

        public DateTime End
        {
            get
            {
                return this.end;
            }
            private set
            {
                Validator.CheckIfDateTimeIsNotNull(value);

                this.end = value;
            }
        }

        public void AddSubTask(ISubTask subtask)
        {
            this.AllTasks.Add(subtask);            
        }

        public double CalcuLateDefaultPriorityOfOne()
        {
            return 100.0 / this.AllTasks.Count;
        }

        public void CalculateDefaultPriorityOfAll()
        {
            var defaultPriority = this.CalcuLateDefaultPriorityOfOne();
            foreach (var subtask in this.AllTasks)
            {
                subtask.ImportancePercent = defaultPriority;
            }
        }

        public override string AdditionalInformation()
        {
            return string.Join(",", this.AllTasks)+" "+ End.ToString("dd/MM/yyyy/HH/mm") + " ";
        }
        
    }
}

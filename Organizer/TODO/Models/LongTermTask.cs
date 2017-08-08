using System;
using System.Collections.Generic;
using TODO.Contracts;
using TODO.Utils.Validator;

namespace TODO.Models
{
    public class LongTermTask : Task, ITask, ILongTermTask, ISaveable
    {
        private ICollection<ISubTask> allTasks;
        private DateTime end;

        public LongTermTask(string title, Priority priority, DateTime end, string description,
            DateTime start = default(DateTime), ICollection<ISubTask> alltasks = null)
            : base(title, priority, description, start)
        {
            this.End = end;
            this.AllTasks = allTasks;
        }

<<<<<<< HEAD
        public ICollection<ISubTask> AllTasks
        {
            get
            {
                return this.allTasks;
            }
            private set
            {
                if (value == null)
                {
                    allTasks = new List<ISubTask>();
                }
                else
                {
                    this.allTasks = value;
                }
            }
        }
=======
>>>>>>> local-branch

        public DateTime End
        {
            get
            {
                return this.end;
            }
<<<<<<< HEAD
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
=======
        }

        public void AddSubTask(SubTask subTask)
        {
            throw new NotImplementedException();
        }

        public void CalculateDefaultPriorityOfAll()
>>>>>>> local-branch
        {
            return $"{ (this.AllTasks.Count==0?"None":string.Join(",", this.AllTasks))}:::{this.End.ToString("dd/MM/yyyy/HH/mm")}";
        }
    }
}

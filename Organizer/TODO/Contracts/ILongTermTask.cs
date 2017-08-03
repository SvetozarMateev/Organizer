using System;
using System.Collections.Generic;

using TODO.Models;

namespace TODO.Contracts
{
    public interface ILongTermTask : ITask
    {
        ICollection<ISubTask> AllTasks { get; }
        DateTime End { get; }
        void CalculateDefaultPriorityOfAll();
        void AddSubTask(ISubTask subtask);

    }
}

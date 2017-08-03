using System;
using System.Collections.Generic;

using TODO.Models;

namespace TODO.Contracts
{
    interface ILongTermTask : ITask
    {
        ICollection<SubTask> AllTasks { get; }
        DateTime End { get; }
        void CalculateDefaultPriorityOfAll();
        void AddSubTask(SubTask subTask);

    }
}

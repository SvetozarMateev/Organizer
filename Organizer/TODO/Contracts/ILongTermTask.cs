using System;
using System.Collections.Generic;

using TODO.Models;

namespace TODO.Contracts
{
    interface ILongTermTask
    {
        ICollection<SubTask> AllTasks { get; }//epizodite
        DateTime End { get; }//posleden epizod
        void CalculateDefaultPriorityOfAll();
        void AddSubTask(SubTask subTask);

    }
}

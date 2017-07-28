using System;
using System.Collections.Generic;

using TODO.Models;

namespace TODO.Contracts
{
    interface ILongTermTask
    {
        ICollection<SubTask> AllTasks { get; }

        DateTime End { get; }
    }
}



using System;
using TODO.Models;

namespace TODO.Contracts
{
    public interface ITask
    {
        string Title { get; }
        string Description { get; }
        DateTime Start { get; }
        IReminder Reminder { get; }
        IUser Author { get; }
        Priority Priority { get; }
        TaskType TaskType { get; }


        //void Sort();
    }
}

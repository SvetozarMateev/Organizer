

using System;
using TODO.Models;

namespace TODO.Contracts
{
    public interface ITask
    {
        string Title { get; }//Seriala imeto
        string Description { get; }
        DateTime Start { get; }// sega
        IReminder Reminder { get; }// novi epizodi
        IUser Author { get; }
        Priority Priority { get; }
        TaskType TaskType { get; }

    }
}

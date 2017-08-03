using System.Collections.Generic;
using TODO.Models;

namespace TODO.Contracts
{
    public interface IUser
    {
        string Username { get; }
        string Password { get; }
        ICollection<INotebook> Notebooks { get; }
        ICollection<ITask> Tasks { get; }
        ICollection<ILongTermTask> LongTermTasks { get; }

        void AddNotebook(INotebook notebook);
        void AddLongTermTask(ILongTermTask longTermTask);
        void DeleteNotebook();
        void AddTask(ITask task);
        void Sort();
        string FormatUserInfoForDB();
    }
}

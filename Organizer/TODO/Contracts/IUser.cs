using System.Collections.Generic;
using TODO.Models;

namespace TODO.Contracts
{
    public interface IUser : ICredentials, ISaveable, ISortable
    {
<<<<<<< HEAD
        ICollection<INotebook> Notebooks { get; }
        ICollection<ITask> Tasks { get; }
        ICollection<ILongTermTask> LongTermTasks { get; }

        void AddNotebook(INotebook notebook);
        void AddLongTermTask(ILongTermTask longTermTask);
=======
        string Username { get; }
        string Password { get; }
        ICollection<INotebook> Notebook { get; }

        void AddNotebook();
>>>>>>> local-branch
        void DeleteNotebook();
        void AddTask(ITask task);
    }
}

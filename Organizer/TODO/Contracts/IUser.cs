using System.Collections.Generic;
using TODO.Models;

namespace TODO.Contracts
{
    public interface IUser
    {
        string Username { get; }
        string Password { get; }
        ICollection<INotebook> Notebooks { get; }

        void AddNotebook(INotebook notebook);
        void DeleteNotebook();
        void Sort();
        string FormatUserInfoForDB();
    }
}

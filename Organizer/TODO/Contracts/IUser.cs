

using System.Collections.Generic;

namespace TODO.Contracts
{
    public interface IUser
    {
        string Username { get; }
        string Password { get; }
        ICollection<INotebook> Notebook { get; }

        void AddNotebook();
        void DeleteNotebook();
    }
}

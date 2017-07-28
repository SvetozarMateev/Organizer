
using System.Collections.Generic;
using TODO.Models;

namespace TODO.Contracts
{
    public interface INotebook
    {
        ICollection<Note> Notes { get; }
        IUser User { get; }
        string Name { get; }
        
    }
}

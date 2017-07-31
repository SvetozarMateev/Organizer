using System.Collections.Generic;
using TODO.Models;

namespace TODO.Contracts
{
    public interface INotebook
    {
        ICollection<Note> Notes { get; }
        IUser User { get; }
        bool IsFavourite { get; }
        string Name { get; }
        void AddNote(Note note);
        void DeleteNote(Note note);
        void EditNote(Note note);

        void Sort();
    }
}



using System;
using System.Collections.Generic;
using TODO.Contracts;

namespace TODO.Models
{
    public class Notebook : INotebook
    {
        public bool IsFavourite
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<Note> Notes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IUser User
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void AddNote(Note note)
        {
            throw new NotImplementedException();
        }

        public void DeleteNote(Note note)
        {
            throw new NotImplementedException();
        }

        public void EditNote(Note note)
        {
            throw new NotImplementedException();
        }
    }
}



using System;
using System.Collections.Generic;
using TODO.Contracts;

namespace TODO.Models
{
    public class Notebook : INotebook
    {
        private string name;
        private IUser user;
        private ICollection<Note> notes;
        private bool isFavourite;

        public Notebook(string name, IUser user, ICollection<Note> notes, bool isFavourite = false)
        {
            this.Name = name;
            this.User = user;
            this.Notes = notes;
            this.IsFavourite = isFavourite;
        }

        public bool IsFavourite
        {
            get
            {
                return this.isFavourite;
            }
            set
            {
                this.IsFavourite = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public ICollection<Note> Notes
        {
            get
            {
                return this.notes;
            }
            set
            {
                this.notes = value;
            }
        }

        public IUser User
        {
            get
            {
                return this.user;
            }
            set
            {
                this.user = value;
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

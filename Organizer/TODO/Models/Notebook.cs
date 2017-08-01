using System;
using System.Collections.Generic;
using TODO.Contracts;
using TODO.Engine;

namespace TODO.Models
{
    public class Notebook : INotebook
    {
        private string name;
        private IUser user;
        private ICollection<Note> notes;
        private bool isFavourite;

        public Notebook(string name, bool isFavourite = false)
        {
            this.Name = name;
            //this.User = user;
            this.Notes = new List<Note>();
            this.IsFavourite = isFavourite;
            this.User = EngineMaikaTI.loggedUser;
        }

        public bool IsFavourite
        {
            get
            {
                return this.isFavourite;
            }
            set
            {
                this.isFavourite = value;
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
        } // tova mai e izlishno, po dobre samo user-a da si pasi Notebook -Marto

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
        public void Sort()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{this.Name} {this.IsFavourite}{Environment.NewLine}" +
                $"{string.Join(" ", this.Notes)}"; // without the user info 
        }
    }
}
